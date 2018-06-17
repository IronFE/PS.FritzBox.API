using System;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// request object for SetConfig
    /// </summary>
    public class SetConfigRequest
    {
        /// <summary>
        /// gets or sets the MaxBitRate
        /// </summary>
        public string MaxBitRate { get; set;}

        /// <summary>
        /// gets or sets the Channel
        /// </summary>
        public Int32 Channel { get; set;}

        /// <summary>
        /// gets or sets the SSID
        /// </summary>
        public string SSID { get; set;}

        /// <summary>
        /// gets or sets the BeaconType
        /// </summary>
        public string BeaconType { get; set;}

        /// <summary>
        /// gets or sets the MACAddressControlEnabled
        /// </summary>
        public bool MACAddressControlEnabled { get; set;}

        /// <summary>
        /// gets or sets the BasicEncryptionModes
        /// </summary>
        public string BasicEncryptionModes { get; set;}

        /// <summary>
        /// gets or sets the BasicAuthenticationMode
        /// </summary>
        public string BasicAuthenticationMode { get; set;}
    }
}