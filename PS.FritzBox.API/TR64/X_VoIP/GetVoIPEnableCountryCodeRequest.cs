using System;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// request object for GetVoIPEnableCountryCode
    /// </summary>
    public class GetVoIPEnableCountryCodeRequest
    {
        /// <summary>
        /// gets or sets the VoIPAccountIndex
        /// </summary>
        public Int32 VoIPAccountIndex { get; set;}
    }
}