﻿using Google.Protobuf;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public enum DBError
    {
        Success,
        IsExisted,
        IsNotExisted,
        ObjectIsEmpty,
        VersionError,
        UnKnowError
    }

    public abstract class Table<TProto, TKey, TTable> where TProto : IMessage<TProto>, new() where TTable : Table<TProto, TKey, TTable>, new()
    {
        public static TTable New() {
            var table = new TTable();
            table.Value = new TProto();
            return table;
        }

#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public Table()
        {

        }
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public TProto Value { get; private set; }

        public abstract string TableName {  get; }

        int version = 0;
        protected abstract string GetKey();
        protected abstract string GetKey(TKey key);
        public async Task<DBError> SaveAync()
        {
            var bitData = Value.ToByteArray();
            var keyString = GetKey();
            // 版本号是0即新增
            if (version == 0)
            {
                var cmd = Database.MySqlConn.CreateCommand(); 
                cmd.CommandText = string.Format("insert into {0} (c_key, c_value, c_version) values(@key,@value,@version);", TableName);
                cmd.Parameters.AddWithValue("@key", keyString);
                cmd.Parameters.AddWithValue("@value", bitData);
                cmd.Parameters.AddWithValue("@version", 1);
                try { 
                    var line = await cmd.ExecuteNonQueryAsync();
                    if (line == 1)
                    {
                        version = 1;
                        return DBError.Success;
                    }
                    else
                        return DBError.IsExisted;
                }
                catch (MySqlException ex) {
                    if (ex.Code == 1602)
                    {
                        return DBError.IsExisted;
                    }
                    return DBError.UnKnowError;
                }
                catch
                {
                    return DBError.UnKnowError;
                }

            }
            else
            {
                var cmd = Database.MySqlConn.CreateCommand();
                cmd.CommandText = string.Format("update {0} set c_value=@value, c_version=@newVersion where c_key=@key and c_version=@oldVersion;", TableName);
                cmd.Parameters.AddWithValue("@key", keyString);
                cmd.Parameters.AddWithValue("@value", bitData);
                cmd.Parameters.AddWithValue("@oldVersion", version);
                cmd.Parameters.AddWithValue("@newVersion", version + 1);
                try
                {
                    var line = await cmd.ExecuteNonQueryAsync();
                    if (line == 1)
                    {
                        version = version + 1;
                        return DBError.Success;
                    }
                    else
                        return DBError.VersionError;
                }
                catch
                {
                    return DBError.UnKnowError;
                }
            }
        }

        public async Task<DBError> DeleteAync()
        {
            if (version == 0)
                return DBError.ObjectIsEmpty;
            var keyString = GetKey();
            var cmd = Database.MySqlConn.CreateCommand();
            cmd.CommandText = string.Format("delete from {0} where c_key=@key;", TableName);
            cmd.Parameters.AddWithValue("@key", keyString);
            try
            {
                var line = await cmd.ExecuteNonQueryAsync();
                if (line == 1)
                {
                    version = 0;
                    return DBError.Success;
                }
                else
                    return DBError.IsExisted;
            }
            catch
            {
                return DBError.UnKnowError;
            }
        }

        public static async Task<(TTable? Row, DBError Error)> QueryAync(TKey key) 
        {
            TTable table = new TTable();
            var tableName = table.TableName;
            var keyString = table.GetKey(key);
            MessageParser<TProto> parser = new MessageParser<TProto>(() => new TProto());
            var cmd = Database.MySqlConn.CreateCommand();
            cmd.CommandText = string.Format("select c_key, c_value, c_version from {0} where c_key=@key;", tableName);
            cmd.Parameters.AddWithValue("@key", keyString);
            try
            {
                var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    reader.GetFieldValue<string>("c_key");
                    var buffer = reader.GetFieldValue<byte[]>("c_value");
                    var version = reader.GetFieldValue<int>("c_version");
                    table.Value = parser.ParseFrom(buffer);
                    table.version = version;
                    reader.Close();
                    return (table, DBError.Success);
                }
                else
                {
                    reader.Close();
                    return (null, DBError.IsNotExisted);
                }
            }
            catch
            {
                return (null, DBError.UnKnowError);
            }
        }

        public static async Task<DBError> DeleteAync(TKey key)
        {
            TTable table = new TTable();
            var keyString = table.GetKey(key);
            var tableName = table.TableName;
            var cmd = Database.MySqlConn.CreateCommand();
            cmd.CommandText = string.Format("delete from {0} where c_key=@key;", tableName);
            cmd.Parameters.AddWithValue("@key", keyString);
            try
            {
                var line = await cmd.ExecuteNonQueryAsync();
                if (line == 1)
                {
                    return DBError.Success;
                }
                else
                    return DBError.IsExisted;
            }
            catch
            {
                return DBError.UnKnowError;
            }
        }

    }
}
