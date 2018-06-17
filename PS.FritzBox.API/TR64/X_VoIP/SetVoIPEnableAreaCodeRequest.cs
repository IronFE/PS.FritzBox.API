using System;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// request object for SetVoIPEnableAreaCode
    /// </summary>
    public class SetVoIPEnableAreaCodeRequest
    {
        /// <summary>
        /// gets or sets the VoIPAccountIndex
        /// </summary>
        public Int32 VoIPAccountIndex { get; set;}

        /// <summary>
        /// gets or sets the VoIPEnableAreaCode
        /// </summary>
        public bool VoIPEnableAreaCode { get; set;}
    }
}