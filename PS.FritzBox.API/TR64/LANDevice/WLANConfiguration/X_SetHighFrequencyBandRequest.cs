using System;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// request object for X_SetHighFrequencyBand
    /// </summary>
    public class X_SetHighFrequencyBandRequest
    {
        /// <summary>
        /// gets or sets the EnableHighFrequency
        /// </summary>
        public bool EnableHighFrequency { get; set;}
    }
}