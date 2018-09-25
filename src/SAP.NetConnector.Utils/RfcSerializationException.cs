
using System;

namespace SAP.Middleware.Connector
{
  public class RfcSerializationException : RfcBaseException
  {

    public RfcSerializationException(string message, RfcSerializationException.RfcComponent component, Exception cause)
    {
    }

    public RfcSerializationException(string message, RfcSerializationException.RfcComponent component)
    {
    }

    public RfcSerializationException(string message)
    {
    }

    public RfcSerializationException.RfcComponent Component => throw new NotImplementedException();

      public enum RfcComponent
    {
      CODEPAGE_CONVERSION,
      TYPE_CONVERSION,
      LZ_COMPRESSION,
      GZIP_COMPRESSION,
      CLASSIC_SERIALIZER,
      XRFC_PARSER,
      BASXML_PARSER,
      RUNTIME,
    }
  }
}
