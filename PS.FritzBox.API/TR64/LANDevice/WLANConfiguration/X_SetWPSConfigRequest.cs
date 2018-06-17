using System;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// request object for X_SetWPSConfig
    /// </summary>
    public class X_SetWPSConfigRequest
    {
        /// <summary>
        /// gets or sets the WPSMode
        /// </summary>
        public string WPSMode { get; set;}

        /// <summary>
        /// gets or sets the WPSClientPIN
        /// </summary>
        public string WPSClientPIN { get; set;}
    }
}