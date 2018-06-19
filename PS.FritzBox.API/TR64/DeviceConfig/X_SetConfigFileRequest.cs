using System;

namespace PS.FritzBox.API.TR64
{
    /// <summary>
    /// request object for X_SetConfigFile
    /// </summary>
    public class X_SetConfigFileRequest
    {
        /// <summary>
        /// gets or sets the Password
        /// </summary>
        public string Password { get; set;}

        /// <summary>
        /// gets or sets the ConfigFileUrl
        /// </summary>
        public string ConfigFileUrl { get; set;}
    }
}