
using System;

namespace SAP.Middleware.Connector
{
  public abstract class RfcBaseException : ApplicationException
  {
    public static int NCO_ERROR_SERVER_SESSION_INVALID = 305;
    public static int NCO_ERROR_SERVER_ACCESS_DENIED = 304;
    public static int NCO_ERROR_FUNCTION_NOT_FOUND = 303;
    public static int NCO_ERROR_SERVER_FUNCTION = 302;
    public static int NCO_ERROR_INVALID_SERVER_FUNCTION = 301;
    public static int NCO_ERROR_SYSTEM_FAILURE = 204;
    public static int NCO_ERROR_ABAP_MESSAGE = 203;
    public static int NCO_ERROR_ABAP_CLASS_EXCEPTION = 202;
    public static int NCO_ERROR_ABAP_EXCEPTION = 201;
    public static int NCO_ERROR_CONNECTION_REFUSED = 107;
    public static int NCO_ERROR_TIMEOUT = 106;
    public static int NCO_ERROR_SERVICE_IN_USE = 105;
    public static int NCO_ERROR_SERVICE_UNKNOWN = 104;
    public static int NCO_ERROR_HOST_UNKNOWN = 103;
    public static int NCO_ERROR_CONNECTION_STATE = 102;
    public static int NCO_ERROR_CONNECTION_RESET_BY_PEER = 101;
    public static int NCO_ERROR_UNSUPPORTED_PARTNER = 16;
    public static int NCO_ERROR_CONCURRENT_CALL = 15;
    public static int NCO_ERROR_RESOURCE = 14;
    public static int NCO_ERROR_BACKGROUND_RFC = 13;
    public static int NCO_ERROR_CONNECTION_CANCELED = 12;
    public static int NCO_ERROR_PASSPORT = 11;
    public static int NCO_ERROR_TYPE_CONVERSION = 10;
    public static int NCO_ERROR_SERIALIZATION = 9;
    public static int NCO_ERROR_INVALID_STATE = 8;
    public static int NCO_ERROR_LOGON_FAILURE = 7;
    public static int NCO_ERROR_INSUFFICIENT_MEMORY = 6;
    public static int NCO_ERROR_SNC = 5;
    public static int NCO_ERROR_LOAD_BALANCING_UNKNOWN_GROUP = 4;
    public static int NCO_ERROR_LOAD_BALANCING = 3;
    public static int NCO_ERROR_INVALID_PARAMETER = 2;
    public static int NCO_ERROR_MISSING_PARAMETER = 1;
    public static int NCO_ERROR_UNSPECIFIED = 0;

    public int ErrorCode => throw new NotImplementedException();

  }
}
