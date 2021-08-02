﻿using Frame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dirapi;
using Google.Protobuf;

namespace DirServer
{
    
    class Server : ServerApp<Server>
    {
        Dispatcher<EOpCode, SHead> dispatcher = new Dispatcher<EOpCode, SHead>(head => { return head.Msgid; });

        Dictionary<string, Dictionary<int, Dictionary<int, ServerInfo>>> servers = new Dictionary<string, Dictionary<int, Dictionary<int, ServerInfo>>>();
        Dictionary<string, Dictionary<int, int>> versions = new Dictionary<string, Dictionary<int, int>>();
        Dictionary<Session, ServerInfo> sessions = new Dictionary<Session, ServerInfo>();
        protected override void OnFini()
        {
            dispatcher.Bind<RegisterReq>(EOpCode.RegisterReq, RegisterServerHandler);
        }

        protected override async Task OnHandlerData(Session session, byte[] data)
        {
            await dispatcher.DispatcherRequest(session, data);
        }

        async Task RegisterServerHandler(Session session, SHead reqHead, RegisterReq reqBody)
        {
            sessions[session] = reqBody.Info;
            var svrs = servers.GetValueOrDefault(reqBody.Info.Name);
            if (svrs == null)
            {
                servers.Add(reqBody.Info.Name, new Dictionary<int, Dictionary<int, ServerInfo>>() { {reqBody.Info.Zone, new Dictionary<int, ServerInfo>() { { reqBody.Info.Id, reqBody.Info} } } });
                versions.Add(reqBody.Info.Name, new Dictionary<int, int>() { { reqBody.Info.Zone, 1} });
            }
            else
            {
                var zones = svrs.GetValueOrDefault(reqBody.Info.Zone);
                if (zones == null)
                {
                    svrs.Add(reqBody.Info.Zone, new Dictionary<int, ServerInfo>() { { reqBody.Info.Id, reqBody.Info } } );
                    versions[reqBody.Info.Name].Add(reqBody.Info.Zone, 1);
                }
                else
                {
                    zones.Add(reqBody.Info.Id, reqBody.Info);
                    versions[reqBody.Info.Name][reqBody.Info.Zone] += 1;
                }
            }
            SHead rspHead = new SHead { Errcode = EErrno.Succ, Sync = reqHead.Sync, Msgid = EOpCode.RegisterRsp };
            RegisterRsp registerRsp = new RegisterRsp { };
            await Send(session, rspHead, registerRsp);
        }
        async Task Send<TRsp>(Session session, SHead head, TRsp rsp) where TRsp : IMessage
        {
            var bodyBits = rsp.ToByteArray();
            var headBits = head.ToByteArray();
            int packLength = bodyBits.Length + headBits.Length + 2 * sizeof(int);
            byte[] data = new byte[packLength];
            var packLengthBits = BitConverter.GetBytes(packLength);
            var headLengthBits = BitConverter.GetBytes(headBits.Length);
            Array.Reverse(packLengthBits);
            Array.Reverse(headLengthBits);
            packLengthBits.CopyTo(data, 0);
            headLengthBits.CopyTo(data, sizeof(int));
            headBits.CopyTo(data, 2 * sizeof(int));
            bodyBits.CopyTo(data, 2 * sizeof(int) + headBits.Length);
            await session.SendAsync(data);
        } 
        protected override void OnInit()
        {

        }

        protected override void OnUpdate()
        {

        }

        protected override void OnConnect(Session session)
        {
        }

        protected override void OnDisconnect(Session session)
        {
           var info = sessions.GetValueOrDefault(session);
           if (info != null)
           {
                servers[info.Name][info.Zone].Remove(info.Id);
                versions[info.Name][info.Id] += 1;
           }
        }
    }
}
