using System;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANIPConnection
{
    /// <summary>
    /// enumeration of ConnectionStatus
    /// </summary>
    public enum ConnectionStatus
    {
        UNCONFIGURED,
        CONNECTING,
        AUTHENTICATING,
        CONNECTED,
        PENDINGDISCONNECT,
        DISCONNECTING,
        DISCONNECTED
    }
}