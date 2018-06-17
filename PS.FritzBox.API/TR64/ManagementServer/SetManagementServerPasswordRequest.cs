using System;

namespace PS.FritzBox.API.TR64.ManagementServer
{
    /// <summary>
    /// request object for SetManagementServerPassword
    /// </summary>
    public class SetManagementServerPasswordRequest
    {
        /// <summary>
        /// gets or sets the Password
        /// </summary>
        public string Password { get; set;}
    }
}