using System;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// request object for SetSSID
    /// </summary>
    public class SetSSIDRequest
    {
        /// <summary>
        /// gets or sets the SSID
        /// </summary>
        public string SSID { get; set;}
    }
}