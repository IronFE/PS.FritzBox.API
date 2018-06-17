using System;

namespace PS.FritzBox.API.TR64.X_WebDAVClient
{
    /// <summary>
    /// request object for SetConfig
    /// </summary>
    public class SetConfigRequest
    {
        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; set;}

        /// <summary>
        /// gets or sets the HostURL
        /// </summary>
        public string HostURL { get; set;}

        /// <summary>
        /// gets or sets the Username
        /// </summary>
        public string Username { get; set;}

        /// <summary>
        /// gets or sets the Password
        /// </summary>
        public string Password { get; set;}

        /// <summary>
        /// gets or sets the MountpointName
        /// </summary>
        public string MountpointName { get; set;}
    }
}