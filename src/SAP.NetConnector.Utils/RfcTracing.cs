// Decompiled with JetBrains decompiler
// Type: SAP.Middleware.Connector.RfcTracing
// Assembly: sapnco_utils, Version=3.0.0.42, Culture=neutral, PublicKeyToken=50436dca5c7f7d23
// MVID: 8391A8AF-D81A-4E21-A78A-5A8CD73CE4BF
// Assembly location: C:\Users\fwagner\source\Repos\dms-connector\src\Contiva.SAP.NetConnector\bin\Debug\net40\sapnco_utils.dll

using System;

namespace SAP.Middleware.Connector
{
  public enum RfcTracing
  {
    None = 0,
    Level1 = 1,
    RemoteFunctionCall = 1,
    PublicAPI = 2,
    Level2 = 3,
    InternalAPI = 4,
    Level3 = 7,
    RfcData = 8,
    Level4 = 15, // 0x0000000F
    ParameterData = 17, // 0x00000011
    Metadata = 34, // 0x00000022
    [Obsolete("use RfcTracing.Performance instead")] FunctionMetadataLookup = 64, // 0x00000040
    Performance = 128, // 0x00000080
    Locking = 256, // 0x00000100
  }
}
