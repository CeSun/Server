// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DataBase/Protocol/database.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DataBase {

  /// <summary>Holder for reflection information generated from DataBase/Protocol/database.proto</summary>
  public static partial class DatabaseReflection {

    #region Descriptor
    /// <summary>File descriptor for DataBase/Protocol/database.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DatabaseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBEYXRhQmFzZS9Qcm90b2NvbC9kYXRhYmFzZS5wcm90bxIIRGF0YUJhc2Ui",
            "kQEKCERCUGxheWVyEgwKBHpvbmUYASABKAUSCwoDdWluGAIgASgEEhAKCG5p",
            "Y2tuYW1lGAMgASgJEhcKD2xhc3RfbG9naW5fdGltZRgEIAEoAxIXCg9sb2dp",
            "bl9zZXJ2ZXJfaWQYBSABKAMSJgoIY3VycmVuY3kYBiADKAsyFC5EYXRhQmFz",
            "ZS5EQkN1cnJlbmN5IiYKCkRCQ3VycmVuY3kSCgoCaWQYASABKAUSDAoEbnVt",
            "cxgCIAEoDSJZCglEQkFjY291bnQSIAoEdHlwZRgBIAEoDjISLkRhdGFCYXNl",
            "LkF1dGhUeXBlEg8KB2FjY291bnQYAiABKAkSDAoEem9uZRgDIAEoBRILCgN1",
            "aW4YBCABKAQiIwoFREJVaW4SDAoEem9uZRgBIAEoBRIMCgRudW1zGAIgASgE",
            "KhQKCEF1dGhUeXBlEggKBFRlc3QQAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::DataBase.AuthType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DataBase.DBPlayer), global::DataBase.DBPlayer.Parser, new[]{ "Zone", "Uin", "Nickname", "LastLoginTime", "LoginServerId", "Currency" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DataBase.DBCurrency), global::DataBase.DBCurrency.Parser, new[]{ "Id", "Nums" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DataBase.DBAccount), global::DataBase.DBAccount.Parser, new[]{ "Type", "Account", "Zone", "Uin" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DataBase.DBUin), global::DataBase.DBUin.Parser, new[]{ "Zone", "Nums" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum AuthType {
    [pbr::OriginalName("Test")] Test = 0,
  }

  #endregion

  #region Messages
  public sealed partial class DBPlayer : pb::IMessage<DBPlayer>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DBPlayer> _parser = new pb::MessageParser<DBPlayer>(() => new DBPlayer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DBPlayer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataBase.DatabaseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DBPlayer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DBPlayer(DBPlayer other) : this() {
      zone_ = other.zone_;
      uin_ = other.uin_;
      nickname_ = other.nickname_;
      lastLoginTime_ = other.lastLoginTime_;
      loginServerId_ = other.loginServerId_;
      currency_ = other.currency_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DBPlayer Clone() {
      return new DBPlayer(this);
    }

    /// <summary>Field number for the "zone" field.</summary>
    public const int ZoneFieldNumber = 1;
    private int zone_;
    /// <summary>
    /// 玩家大区
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Zone {
      get { return zone_; }
      set {
        zone_ = value;
      }
    }

    /// <summary>Field number for the "uin" field.</summary>
    public const int UinFieldNumber = 2;
    private ulong uin_;
    /// <summary>
    /// 玩家唯一标识
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Uin {
      get { return uin_; }
      set {
        uin_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 3;
    private string nickname_ = "";
    /// <summary>
    /// 玩家昵称
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_login_time" field.</summary>
    public const int LastLoginTimeFieldNumber = 4;
    private long lastLoginTime_;
    /// <summary>
    /// 最后一次登录时间
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long LastLoginTime {
      get { return lastLoginTime_; }
      set {
        lastLoginTime_ = value;
      }
    }

    /// <summary>Field number for the "login_server_id" field.</summary>
    public const int LoginServerIdFieldNumber = 5;
    private long loginServerId_;
    /// <summary>
    /// 登录的服务器实例id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long LoginServerId {
      get { return loginServerId_; }
      set {
        loginServerId_ = value;
      }
    }

    /// <summary>Field number for the "currency" field.</summary>
    public const int CurrencyFieldNumber = 6;
    private static readonly pb::FieldCodec<global::DataBase.DBCurrency> _repeated_currency_codec
        = pb::FieldCodec.ForMessage(50, global::DataBase.DBCurrency.Parser);
    private readonly pbc::RepeatedField<global::DataBase.DBCurrency> currency_ = new pbc::RepeatedField<global::DataBase.DBCurrency>();
    /// <summary>
    /// 货币
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::DataBase.DBCurrency> Currency {
      get { return currency_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DBPlayer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DBPlayer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Zone != other.Zone) return false;
      if (Uin != other.Uin) return false;
      if (Nickname != other.Nickname) return false;
      if (LastLoginTime != other.LastLoginTime) return false;
      if (LoginServerId != other.LoginServerId) return false;
      if(!currency_.Equals(other.currency_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Zone != 0) hash ^= Zone.GetHashCode();
      if (Uin != 0UL) hash ^= Uin.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (LastLoginTime != 0L) hash ^= LastLoginTime.GetHashCode();
      if (LoginServerId != 0L) hash ^= LoginServerId.GetHashCode();
      hash ^= currency_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Zone != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Zone);
      }
      if (Uin != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Uin);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nickname);
      }
      if (LastLoginTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(LastLoginTime);
      }
      if (LoginServerId != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(LoginServerId);
      }
      currency_.WriteTo(output, _repeated_currency_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Zone != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Zone);
      }
      if (Uin != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Uin);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nickname);
      }
      if (LastLoginTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(LastLoginTime);
      }
      if (LoginServerId != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(LoginServerId);
      }
      currency_.WriteTo(ref output, _repeated_currency_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Zone != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Zone);
      }
      if (Uin != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Uin);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (LastLoginTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastLoginTime);
      }
      if (LoginServerId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LoginServerId);
      }
      size += currency_.CalculateSize(_repeated_currency_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DBPlayer other) {
      if (other == null) {
        return;
      }
      if (other.Zone != 0) {
        Zone = other.Zone;
      }
      if (other.Uin != 0UL) {
        Uin = other.Uin;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.LastLoginTime != 0L) {
        LastLoginTime = other.LastLoginTime;
      }
      if (other.LoginServerId != 0L) {
        LoginServerId = other.LoginServerId;
      }
      currency_.Add(other.currency_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Zone = input.ReadInt32();
            break;
          }
          case 16: {
            Uin = input.ReadUInt64();
            break;
          }
          case 26: {
            Nickname = input.ReadString();
            break;
          }
          case 32: {
            LastLoginTime = input.ReadInt64();
            break;
          }
          case 40: {
            LoginServerId = input.ReadInt64();
            break;
          }
          case 50: {
            currency_.AddEntriesFrom(input, _repeated_currency_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Zone = input.ReadInt32();
            break;
          }
          case 16: {
            Uin = input.ReadUInt64();
            break;
          }
          case 26: {
            Nickname = input.ReadString();
            break;
          }
          case 32: {
            LastLoginTime = input.ReadInt64();
            break;
          }
          case 40: {
            LoginServerId = input.ReadInt64();
            break;
          }
          case 50: {
            currency_.AddEntriesFrom(ref input, _repeated_currency_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class DBCurrency : pb::IMessage<DBCurrency>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DBCurrency> _parser = new pb::MessageParser<DBCurrency>(() => new DBCurrency());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DBCurrency> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataBase.DatabaseReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DBCurrency() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DBCurrency(DBCurrency other) : this() {
      id_ = other.id_;
      nums_ = other.nums_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DBCurrency Clone() {
      return new DBCurrency(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    /// <summary>
    /// 道具的id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "nums" field.</summary>
    public const int NumsFieldNumber = 2;
    private uint nums_;
    /// <summary>
    /// 数量
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Nums {
      get { return nums_; }
      set {
        nums_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DBCurrency);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DBCurrency other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Nums != other.Nums) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Nums != 0) hash ^= Nums.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Nums != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Nums);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Nums != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Nums);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Nums != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Nums);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DBCurrency other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Nums != 0) {
        Nums = other.Nums;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            Nums = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            Nums = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class DBAccount : pb::IMessage<DBAccount>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DBAccount> _parser = new pb::MessageParser<DBAccount>(() => new DBAccount());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DBAccount> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataBase.DatabaseReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DBAccount() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DBAccount(DBAccount other) : this() {
      type_ = other.type_;
      account_ = other.account_;
      zone_ = other.zone_;
      uin_ = other.uin_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DBAccount Clone() {
      return new DBAccount(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::DataBase.AuthType type_ = global::DataBase.AuthType.Test;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::DataBase.AuthType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "account" field.</summary>
    public const int AccountFieldNumber = 2;
    private string account_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Account {
      get { return account_; }
      set {
        account_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "zone" field.</summary>
    public const int ZoneFieldNumber = 3;
    private int zone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Zone {
      get { return zone_; }
      set {
        zone_ = value;
      }
    }

    /// <summary>Field number for the "uin" field.</summary>
    public const int UinFieldNumber = 4;
    private ulong uin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Uin {
      get { return uin_; }
      set {
        uin_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DBAccount);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DBAccount other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Account != other.Account) return false;
      if (Zone != other.Zone) return false;
      if (Uin != other.Uin) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::DataBase.AuthType.Test) hash ^= Type.GetHashCode();
      if (Account.Length != 0) hash ^= Account.GetHashCode();
      if (Zone != 0) hash ^= Zone.GetHashCode();
      if (Uin != 0UL) hash ^= Uin.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Type != global::DataBase.AuthType.Test) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Account.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Account);
      }
      if (Zone != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Zone);
      }
      if (Uin != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(Uin);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Type != global::DataBase.AuthType.Test) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Account.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Account);
      }
      if (Zone != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Zone);
      }
      if (Uin != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(Uin);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Type != global::DataBase.AuthType.Test) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Account.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Account);
      }
      if (Zone != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Zone);
      }
      if (Uin != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Uin);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DBAccount other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::DataBase.AuthType.Test) {
        Type = other.Type;
      }
      if (other.Account.Length != 0) {
        Account = other.Account;
      }
      if (other.Zone != 0) {
        Zone = other.Zone;
      }
      if (other.Uin != 0UL) {
        Uin = other.Uin;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Type = (global::DataBase.AuthType) input.ReadEnum();
            break;
          }
          case 18: {
            Account = input.ReadString();
            break;
          }
          case 24: {
            Zone = input.ReadInt32();
            break;
          }
          case 32: {
            Uin = input.ReadUInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Type = (global::DataBase.AuthType) input.ReadEnum();
            break;
          }
          case 18: {
            Account = input.ReadString();
            break;
          }
          case 24: {
            Zone = input.ReadInt32();
            break;
          }
          case 32: {
            Uin = input.ReadUInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class DBUin : pb::IMessage<DBUin>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DBUin> _parser = new pb::MessageParser<DBUin>(() => new DBUin());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DBUin> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataBase.DatabaseReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DBUin() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DBUin(DBUin other) : this() {
      zone_ = other.zone_;
      nums_ = other.nums_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DBUin Clone() {
      return new DBUin(this);
    }

    /// <summary>Field number for the "zone" field.</summary>
    public const int ZoneFieldNumber = 1;
    private int zone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Zone {
      get { return zone_; }
      set {
        zone_ = value;
      }
    }

    /// <summary>Field number for the "nums" field.</summary>
    public const int NumsFieldNumber = 2;
    private ulong nums_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Nums {
      get { return nums_; }
      set {
        nums_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DBUin);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DBUin other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Zone != other.Zone) return false;
      if (Nums != other.Nums) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Zone != 0) hash ^= Zone.GetHashCode();
      if (Nums != 0UL) hash ^= Nums.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Zone != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Zone);
      }
      if (Nums != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Nums);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Zone != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Zone);
      }
      if (Nums != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Nums);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Zone != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Zone);
      }
      if (Nums != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Nums);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DBUin other) {
      if (other == null) {
        return;
      }
      if (other.Zone != 0) {
        Zone = other.Zone;
      }
      if (other.Nums != 0UL) {
        Nums = other.Nums;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Zone = input.ReadInt32();
            break;
          }
          case 16: {
            Nums = input.ReadUInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Zone = input.ReadInt32();
            break;
          }
          case 16: {
            Nums = input.ReadUInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
