
using System;

namespace SAP.Middleware.Connector
{
  public class RfcInvalidStateException : RfcBaseException
  {
    public RfcInvalidStateException(string message, Exception innerExc)
    {
    }

    public RfcInvalidStateException(string message)
    {
    }
  }
}
