using System;

namespace PS.FritzBox.API.TR64.LANDevice.Hosts
{
    /// <summary>
    /// request object for X_SetAutoWakeOnLANByMACAddress
    /// </summary>
    public class X_SetAutoWakeOnLANByMACAddressRequest
    {
        /// <summary>
        /// gets or sets the MACAddress
        /// </summary>
        public string MACAddress { get; set;}

        /// <summary>
        /// gets or sets the AutoWOLEnabled
        /// </summary>
        public bool AutoWOLEnabled { get; set;}
    }
}