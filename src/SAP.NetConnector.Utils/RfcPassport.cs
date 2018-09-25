using System;
using System.Runtime.InteropServices;

namespace SAP.Middleware.Connector
{
  public class RfcPassport : IDisposable
  {

    public RfcPassport(string hexEppStream)
    {
        throw new NotImplementedException();
    }

    public RfcPassport(byte[] eppStream, int offset, int length)
    {
        throw new NotImplementedException();

    }

    public RfcPassport()
    {
        throw new NotImplementedException();
    }

    public static RfcPassport.EppVersion ActiveVersion => throw new NotImplementedException();

      public static int TraceLevel
    {
      set => throw new NotImplementedException();
      }

    public string Serialize()
    {
        throw new NotImplementedException();
    }

        public uint Serialize(ref byte[] buffer)
    {
        throw new NotImplementedException();
    }

        public RfcPassport.EppTraceFlag TraceFlag
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

    public string ComponentName
    {
      get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string PreComponentName
    {
      get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public ushort Service
    {
      get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string User
    {
      get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string Client
    {
      get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string Action
    {
      get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public RfcPassport.EppActionType ActionType
    {
      get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string TransactionId
    {
      get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public RfcPassport.EppComponentType Component => throw new NotImplementedException();

      public ValueType RootContextId
    {
      get => throw new NotImplementedException();
          set => throw new NotImplementedException();
      }

    public ValueType ConnectionId
    {
      get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public uint ConnectionCounter
    {
      get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public RfcPassport.EppVersion Version => throw new NotImplementedException();

      public RfcPassport.VarPartItem get_SystemVarPartItems(ushort index)
    {
        throw new NotImplementedException();
    }

        public RfcPassport.VarPartItem get_ApplVarPartItems(ushort index)
    {
        throw new NotImplementedException();
    }

    public RfcPassport.VarPartItem GetSystemVarPartItem(ushort id, ushort key)
    {
        throw new NotImplementedException();
    }

      public void SetSystemVarPartItem(RfcPassport.VarPartItem item)
      {
          throw new NotImplementedException();
      }

      public ushort GetSystemVarPartItemCount(ushort id)
    {
        throw new NotImplementedException();
    }

            public void ClearSystemVarPartItem(ushort id, ushort key)
    {
        throw new NotImplementedException();
    }

        public void ClearSystemVarPart()
    {
        throw new NotImplementedException();
    }

        public RfcPassport.VarPartItem GetApplVarPartItem(ushort id, ushort key)
    {
        throw new NotImplementedException();
    }

        public void SetApplVarPartItem(RfcPassport.VarPartItem item)
    {
        throw new NotImplementedException();
    }

      public ushort GetApplVarPartItemCount(ushort id)
      {
          throw new NotImplementedException();
      }

      public void ClearApplVarPartItem(ushort id, ushort key)
    {
        throw new NotImplementedException();
    }

            public void ClearApplVarPart()
    {
        throw new NotImplementedException();
    }

        public virtual void Dispose()
    {
        throw new NotImplementedException();
    }


    public enum EppComponentType : ushort
    {
      UNDEF,
      WEBAS,
      J2EE,
      TREX,
      ICM,
      GATEWAY,
      CPIC,
      BROWSERPLUGIN,
      E2ETRACELIB,
      DOTNETCONN,
    }

    public enum EppVersion : byte
    {
      VERSION_1 = 1,
      VERSION_2 = 2,
      Default = 3,
      VERSION_3 = 3,
    }

    public enum EppTraceFlag : ushort
    {
      SQL = 1,
      BUFFER = 2,
      ENQUEUE = 4,
      RFC = 8,
      AUTH = 16, // 0x0010
      CFUNC = 32, // 0x0020
      USER = 64, // 0x0040
      ABAP = 128, // 0x0080
      COND1 = 256, // 0x0100
      COND2 = 512, // 0x0200
      SAT = 1024, // 0x0400
      WS = 2048, // 0x0800
      HTTP = 4096, // 0x1000
    }

    public enum EppActionType : ushort
    {
      UNDEF,
      TCODE,
      BATCH_JOB,
      REPORT,
      WEBSERIVCE,
      UNUSED_1,
      UNUSED_2,
      UNUSED_3,
      UNUSED_4,
      UNUSED_5,
      UNUSED_6,
    }

    public enum EppValueType : byte
    {
      BYTE_ARRAY = 1,
      INTEGER = 2,
      UUID = 3,
      STRING = 4,
    }

    public class VarPartItem
    {
      public ushort id;
      public ushort key;
      public RfcPassport.EppValueType type;
      public object value;

      public VarPartItem(ushort id, ushort key, RfcPassport.EppValueType type, object value)
      {
        this.id = id;
        this.key = key;
        this.type = type;
        this.value = value;
      }

      public VarPartItem()
      {
      }
    }
  }
}
