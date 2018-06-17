using System;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// request object for SetVoIPEnableCountryCode
    /// </summary>
    public class SetVoIPEnableCountryCodeRequest
    {
        /// <summary>
        /// gets or sets the VoIPAccountIndex
        /// </summary>
        public Int32 VoIPAccountIndex { get; set;}

        /// <summary>
        /// gets or sets the VoIPEnableCountryCode
        /// </summary>
        public bool VoIPEnableCountryCode { get; set;}
    }
}