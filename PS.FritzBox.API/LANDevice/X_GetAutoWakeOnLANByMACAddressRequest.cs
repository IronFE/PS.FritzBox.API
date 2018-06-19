using System;

namespace PS.FritzBox.API.LANDevice
{
    /// <summary>
    /// request object for X_GetAutoWakeOnLANByMACAddress
    /// </summary>
    public class X_GetAutoWakeOnLANByMACAddressRequest
    {
        /// <summary>
        /// gets or sets the MACAddress
        /// </summary>
        public string MACAddress { get; set;}
    }
}