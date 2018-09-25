
using System;

namespace SAP.Middleware.Connector
{
  public class RfcInvalidParameterException : RfcBaseException
  {
    public RfcInvalidParameterException(string message, Exception innerExc)
    {
    }

    public RfcInvalidParameterException(string message)
    {
    }
  }
}
