using System;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// enumeration of ConnectionStatus
    /// </summary>
    public enum ConnectionStatus
    {
        UNCONFIGURED,
        CONNECTING,
        AUTHENTICATING,
        PENDINGDISCONNECT,
        DISCONNECTING,
        DISCONNECTED,
        CONNECTED
    }
}