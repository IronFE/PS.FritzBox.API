using System;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// request object for X_AddVoIPAccount
    /// </summary>
    public class X_AddVoIPAccountRequest
    {
        /// <summary>
        /// gets or sets the VoIPAccountIndex
        /// </summary>
        public Int32 VoIPAccountIndex { get; set;}

        /// <summary>
        /// gets or sets the VoIPRegistrar
        /// </summary>
        public string VoIPRegistrar { get; set;}

        /// <summary>
        /// gets or sets the VoIPNumber
        /// </summary>
        public string VoIPNumber { get; set;}

        /// <summary>
        /// gets or sets the VoIPUsername
        /// </summary>
        public string VoIPUsername { get; set;}

        /// <summary>
        /// gets or sets the VoIPPassword
        /// </summary>
        public string VoIPPassword { get; set;}

        /// <summary>
        /// gets or sets the VoIPOutboundProxy
        /// </summary>
        public string VoIPOutboundProxy { get; set;}

        /// <summary>
        /// gets or sets the VoIPSTUNServer
        /// </summary>
        public string VoIPSTUNServer { get; set;}
    }
}