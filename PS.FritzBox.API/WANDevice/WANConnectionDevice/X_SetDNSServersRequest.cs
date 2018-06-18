using System;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// request object for X_SetDNSServers
    /// </summary>
    public class X_SetDNSServersRequest
    {
        /// <summary>
        /// gets or sets the DNSServers
        /// </summary>
        public string DNSServers { get; set;}
    }
}