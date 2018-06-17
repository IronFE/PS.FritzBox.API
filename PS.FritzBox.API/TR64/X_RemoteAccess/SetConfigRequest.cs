using System;

namespace PS.FritzBox.API.TR64.X_RemoteAccess
{
    /// <summary>
    /// request object for SetConfig
    /// </summary>
    public class SetConfigRequest
    {
        /// <summary>
        /// gets or sets the Enabled
        /// </summary>
        public bool Enabled { get; set;}

        /// <summary>
        /// gets or sets the Port
        /// </summary>
        public string Port { get; set;}

        /// <summary>
        /// gets or sets the Username
        /// </summary>
        public string Username { get; set;}

        /// <summary>
        /// gets or sets the Password
        /// </summary>
        public string Password { get; set;}
    }
}