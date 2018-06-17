using System;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANIPConnection
{
    /// <summary>
    /// enumeration of LastConnectionError
    /// </summary>
    public enum LastConnectionError
    {
        ERROR_NONE,
        ERROR_ISP_TIME_OUT,
        ERROR_COMMAND_ABORTED,
        ERROR_NOT_ENABLED_FOR_INTERNET,
        ERROR_BAD_PHONE_NUMBER,
        ERROR_USER_DISCONNECT,
        ERROR_ISP_DISCONNECT,
        ERROR_IDLE_DISCONNECT,
        ERROR_FORCED_DISCONNECT,
        ERROR_SERVER_OUT_OF_RESOURCES,
        ERROR_RESTRICTED_LOGON_HOURS,
        ERROR_ACCOUNT_DISABLED,
        ERROR_ACCOUNT_EXPIRED,
        ERROR_PASSWORD_EXPIRED,
        ERROR_AUTHENTICATION_FAILURE,
        ERROR_NO_DIALTONE,
        ERROR_NO_CARRIER,
        ERROR_NO_ANSWER,
        ERROR_LINE_BUSY,
        ERROR_UNSUPPORTED_BITSPERSECOND,
        ERROR_TOO_MANY_LINE_ERRORS,
        ERROR_IP_CONFIGURATION,
        ERROR_UNKNOWN
    }
}