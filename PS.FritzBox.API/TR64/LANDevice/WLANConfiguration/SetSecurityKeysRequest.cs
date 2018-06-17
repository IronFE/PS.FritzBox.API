using System;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// request object for SetSecurityKeys
    /// </summary>
    public class SetSecurityKeysRequest
    {
        /// <summary>
        /// gets or sets the WEPKey0
        /// </summary>
        public string WEPKey0 { get; set;}

        /// <summary>
        /// gets or sets the WEPKey1
        /// </summary>
        public string WEPKey1 { get; set;}

        /// <summary>
        /// gets or sets the WEPKey2
        /// </summary>
        public string WEPKey2 { get; set;}

        /// <summary>
        /// gets or sets the WEPKey3
        /// </summary>
        public string WEPKey3 { get; set;}

        /// <summary>
        /// gets or sets the PreSharedKey
        /// </summary>
        public string PreSharedKey { get; set;}

        /// <summary>
        /// gets or sets the KeyPassphrase
        /// </summary>
        public string KeyPassphrase { get; set;}
    }
}