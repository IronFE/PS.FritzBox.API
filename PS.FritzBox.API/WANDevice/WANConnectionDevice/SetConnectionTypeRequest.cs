using System;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// request object for SetConnectionType
    /// </summary>
    public class SetConnectionTypeRequest
    {
        /// <summary>
        /// gets or sets the ConnectionType
        /// </summary>
        public ConnectionType ConnectionType { get; set;}
    }
}