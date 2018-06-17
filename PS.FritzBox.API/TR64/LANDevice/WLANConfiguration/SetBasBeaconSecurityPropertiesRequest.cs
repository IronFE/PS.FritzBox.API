using System;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// request object for SetBasBeaconSecurityProperties
    /// </summary>
    public class SetBasBeaconSecurityPropertiesRequest
    {
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