using System;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// request object for GetVoIPEnableAreaCode
    /// </summary>
    public class GetVoIPEnableAreaCodeRequest
    {
        /// <summary>
        /// gets or sets the VoIPAccountIndex
        /// </summary>
        public Int32 VoIPAccountIndex { get; set;}
    }
}