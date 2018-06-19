using System;

namespace PS.FritzBox.API.LANDevice
{
    /// <summary>
    /// request object for X_WakeOnLANByMACAddress
    /// </summary>
    public class X_WakeOnLANByMACAddressRequest
    {
        /// <summary>
        /// gets or sets the MACAddress
        /// </summary>
        public string MACAddress { get; set;}
    }
}