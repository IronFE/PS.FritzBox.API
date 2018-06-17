using System;

namespace PS.FritzBox.API.TR64.X_RemoteAccess
{
    /// <summary>
    /// request object for SetDDNSConfig
    /// </summary>
    public class SetDDNSConfigRequest
    {
        /// <summary>
        /// gets or sets the Enabled
        /// </summary>
        public bool Enabled { get; set;}

        /// <summary>
        /// gets or sets the ProviderName
        /// </summary>
        public string ProviderName { get; set;}

        /// <summary>
        /// gets or sets the UpdateURL
        /// </summary>
        public string UpdateURL { get; set;}

        /// <summary>
        /// gets or sets the Domain
        /// </summary>
        public string Domain { get; set;}

        /// <summary>
        /// gets or sets the Username
        /// </summary>
        public string Username { get; set;}

        /// <summary>
        /// gets or sets the Mode
        /// </summary>
        public Mode Mode { get; set;}

        /// <summary>
        /// gets or sets the ServerIPv4
        /// </summary>
        public string ServerIPv4 { get; set;}

        /// <summary>
        /// gets or sets the ServerIPv6
        /// </summary>
        public string ServerIPv6 { get; set;}

        /// <summary>
        /// gets or sets the Password
        /// </summary>
        public string Password { get; set;}
    }
}