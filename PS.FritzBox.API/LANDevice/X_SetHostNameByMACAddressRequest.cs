using System;

namespace PS.FritzBox.API.TR64.LANDevice.Hosts
{
    /// <summary>
    /// request object for X_SetHostNameByMACAddress
    /// </summary>
    public class X_SetHostNameByMACAddressRequest
    {
        /// <summary>
        /// gets or sets the MACAddress
        /// </summary>
        public string MACAddress { get; set;}

        /// <summary>
        /// gets or sets the HostName
        /// </summary>
        public string HostName { get; set;}
    }
}