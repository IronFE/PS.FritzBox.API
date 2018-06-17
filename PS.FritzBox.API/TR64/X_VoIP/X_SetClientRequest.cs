using System;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// request object for X_SetClient
    /// </summary>
    public class X_SetClientRequest
    {
        /// <summary>
        /// gets or sets the ClientIndex
        /// </summary>
        public Int32 ClientIndex { get; set;}

        /// <summary>
        /// gets or sets the ClientPassword
        /// </summary>
        public string ClientPassword { get; set;}

        /// <summary>
        /// gets or sets the PhoneName
        /// </summary>
        public string PhoneName { get; set;}

        /// <summary>
        /// gets or sets the OutGoingNumber
        /// </summary>
        public string OutGoingNumber { get; set;}
    }
}