using System;

namespace PS.FritzBox.API.TR64.LANConfigSecurity
{
    /// <summary>
    /// request object for SetConfigPassword
    /// </summary>
    public class SetConfigPasswordRequest
    {
        /// <summary>
        /// gets or sets the Password
        /// </summary>
        public string Password { get; set;}
    }
}