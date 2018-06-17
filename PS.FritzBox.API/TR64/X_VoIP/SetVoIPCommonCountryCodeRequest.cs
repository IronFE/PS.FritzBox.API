using System;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// request object for SetVoIPCommonCountryCode
    /// </summary>
    public class SetVoIPCommonCountryCodeRequest
    {
        /// <summary>
        /// gets or sets the VoIPCountryCode
        /// </summary>
        public string VoIPCountryCode { get; set;}
    }
}