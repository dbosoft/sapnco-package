
using System;
using System.Runtime.InteropServices;

namespace SAP.Middleware.Connector
{
  public class RfcTrace
  {
    [Obsolete("use (uint)RfcTracing.None instead")]
    public static uint NONE = 0;
    [Obsolete("use (uint)RfcTracing.Level1 instead")]
    public static uint LEVEL1 = 1;
    [Obsolete("use (uint)RfcTracing.Level2 instead")]
    public static uint LEVEL2 = RfcTrace.LEVEL1 | 2U;
    [Obsolete("use (uint)RfcTracing.Level3 instead")]
    public static uint LEVEL3 = RfcTrace.LEVEL2 | 4U;
    [Obsolete("use (uint)RfcTracing.Level4 instead")]
    public static uint LEVEL4 = RfcTrace.LEVEL3 | 8U;

    public static uint DefaultTraceLevel
    {
      set => throw new NotImplementedException();
        get => throw new NotImplementedException();
    }

    public static bool TracePerThread
    {
      [return: MarshalAs(UnmanagedType.U1)] get => throw new NotImplementedException();
        [param: MarshalAs(UnmanagedType.U1)] set => throw new NotImplementedException();
    }

    public static string TraceDirectory
    {
      get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public static string TraceEncoding
    {
      get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

  }
}
