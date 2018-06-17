using System;

namespace PS.FritzBox.API.TR64.X_AppSetup
{
    /// <summary>
    /// request object for SetAppVPN
    /// </summary>
    public class SetAppVPNRequest
    {
        /// <summary>
        /// gets or sets the AppId
        /// </summary>
        public string AppId { get; set;}

        /// <summary>
        /// gets or sets the IPSecIdentifier
        /// </summary>
        public string IPSecIdentifier { get; set;}

        /// <summary>
        /// gets or sets the IPSecPreSharedKey
        /// </summary>
        public string IPSecPreSharedKey { get; set;}

        /// <summary>
        /// gets or sets the IPSecXauthUsername
        /// </summary>
        public string IPSecXauthUsername { get; set;}

        /// <summary>
        /// gets or sets the IPSecXauthPassword
        /// </summary>
        public string IPSecXauthPassword { get; set;}
    }
}