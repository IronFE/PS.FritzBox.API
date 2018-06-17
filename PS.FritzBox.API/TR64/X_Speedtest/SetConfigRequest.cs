using System;

namespace PS.FritzBox.API.TR64.X_Speedtest
{
    /// <summary>
    /// request object for SetConfig
    /// </summary>
    public class SetConfigRequest
    {
        /// <summary>
        /// gets or sets the EnableTcp
        /// </summary>
        public bool EnableTcp { get; set;}

        /// <summary>
        /// gets or sets the EnableUdp
        /// </summary>
        public bool EnableUdp { get; set;}

        /// <summary>
        /// gets or sets the EnableUdpBidirect
        /// </summary>
        public bool EnableUdpBidirect { get; set;}

        /// <summary>
        /// gets or sets the WANEnableTcp
        /// </summary>
        public bool WANEnableTcp { get; set;}

        /// <summary>
        /// gets or sets the WANEnableUdp
        /// </summary>
        public bool WANEnableUdp { get; set;}
    }
}