using System;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// request object for X_SetWLANHybridMode
    /// </summary>
    public class X_SetWLANHybridModeRequest
    {
        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; set;}

        /// <summary>
        /// gets or sets the BeaconType
        /// </summary>
        public string BeaconType { get; set;}

        /// <summary>
        /// gets or sets the KeyPassphrase
        /// </summary>
        public string KeyPassphrase { get; set;}

        /// <summary>
        /// gets or sets the SSID
        /// </summary>
        public string SSID { get; set;}

        /// <summary>
        /// gets or sets the BSSID
        /// </summary>
        public string BSSID { get; set;}

        /// <summary>
        /// gets or sets the TrafficMode
        /// </summary>
        public string TrafficMode { get; set;}

        /// <summary>
        /// gets or sets the ManualSpeed
        /// </summary>
        public bool ManualSpeed { get; set;}

        /// <summary>
        /// gets or sets the MaxSpeedDS
        /// </summary>
        public Int32 MaxSpeedDS { get; set;}

        /// <summary>
        /// gets or sets the MaxSpeedUS
        /// </summary>
        public Int32 MaxSpeedUS { get; set;}
    }
}