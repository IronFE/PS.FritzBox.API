using System;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// request object for X_SetStickSurfEnable
    /// </summary>
    public class X_SetStickSurfEnableRequest
    {
        /// <summary>
        /// gets or sets the StickSurfEnable
        /// </summary>
        public bool StickSurfEnable { get; set;}
    }
}