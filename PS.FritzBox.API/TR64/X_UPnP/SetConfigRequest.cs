using System;

namespace PS.FritzBox.API.TR64.X_UPnP
{
    /// <summary>
    /// request object for SetConfig
    /// </summary>
    public class SetConfigRequest
    {
        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; set;}

        /// <summary>
        /// gets or sets the UPnPMediaServer
        /// </summary>
        public bool UPnPMediaServer { get; set;}
    }
}