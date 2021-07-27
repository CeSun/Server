﻿using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame
{
    /// <summary>
    /// 协议派发类
    /// </summary>
    /// <typeparam name="TMsgId">消息id类型</typeparam>
    /// <typeparam name="THead">消息头类型</typeparam>
    public class Dispatcher <TMsgId, THead> where THead : IMessage<THead>, new()
    {
        /// <summary>
        /// 协议处理函数
        /// </summary>
        /// <typeparam name="TBody">消息体的类型</typeparam>
        /// <param name="head">消息头</param>
        /// <param name="body">消息体</param>
        /// <returns>无返回值</returns>
        public delegate Task ProcessFun<TBody>(THead head, TBody body);

        /// <summary>
        /// 从Head中取消息id函数
        /// </summary>
        /// <param name="head">head对象</param>
        /// <returns>返回消息id</returns>
        public delegate TMsgId GetMsgIdFunc(THead head);

        public delegate bool RequestHandler(THead head);

        public List<RequestHandler> requestHandlers = new List<RequestHandler>();

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="func">需要一个函数，从head中取msgid</param>
        public Dispatcher(GetMsgIdFunc func)
        {
            getMsgId = func;
        }

        /// <summary>
        /// 注册协议处理函数
        /// </summary>
        /// <typeparam name="TBody">消息体类型</typeparam>
        /// <param name="MessageId">消息id</param>
        /// <param name="func">处理函数</param>
        public void Bind<TBody>(TMsgId MessageId, ProcessFun<TBody> func) where TBody : IMessage<TBody>, new()
        {
            Functions.Add(MessageId, async (offset, head, data) => {
                MessageParser<TBody> parser = new MessageParser<TBody>(() => new TBody());
                var rsp = parser.ParseFrom(data, offset, data.Length - offset);
                if (rsp == null)
                    return;
                 await func(head, rsp);
            });
        }

        /// <summary>
        /// 派发协议
        /// </summary>
        /// <param name="data">数据二进制</param>
        /// <returns></returns>
        public async Task DispatcherRequest(byte[] data)
        {
            var headBits = data.Skip(sizeof(int)).Take(sizeof(int)).ToArray();
            Array.Reverse(headBits);
            var headLength = BitConverter.ToInt32(headBits, 0);

            MessageParser<THead> parser = new MessageParser<THead>(() => new THead());
            var head = parser.ParseFrom(data, sizeof(int) *2, headLength);
            if (head == null)
                return;
            if (getMsgId == default)
                return;


            foreach (var handler in requestHandlers)
            {
                var ret = handler(head);
                if (ret == false)
                    return;
            }
            var id = getMsgId(head);
            var fun = Functions.GetValueOrDefault(id);
            if (fun != null)
            {
                await fun(sizeof(int) * 2 + headLength, head, data);
            }
        }

        delegate Task ProcessFun(int offset, THead head, byte[] body);
        GetMsgIdFunc getMsgId;
        Dictionary<TMsgId, ProcessFun> Functions = new Dictionary<TMsgId, ProcessFun>();
    }
}
