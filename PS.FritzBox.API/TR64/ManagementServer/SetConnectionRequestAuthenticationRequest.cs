using System;

namespace PS.FritzBox.API.TR64.ManagementServer
{
    /// <summary>
    /// request object for SetConnectionRequestAuthentication
    /// </summary>
    public class SetConnectionRequestAuthenticationRequest
    {
        /// <summary>
        /// gets or sets the ConnectionRequestUsername
        /// </summary>
        public string ConnectionRequestUsername { get; set;}

        /// <summary>
        /// gets or sets the ConnectionRequestPassword
        /// </summary>
        public string ConnectionRequestPassword { get; set;}
    }
}