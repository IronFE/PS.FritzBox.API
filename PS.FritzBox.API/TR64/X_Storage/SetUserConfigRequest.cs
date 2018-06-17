using System;

namespace PS.FritzBox.API.TR64.X_Storage
{
    /// <summary>
    /// request object for SetUserConfig
    /// </summary>
    public class SetUserConfigRequest
    {
        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; set;}

        /// <summary>
        /// gets or sets the Password
        /// </summary>
        public string Password { get; set;}

        /// <summary>
        /// gets or sets the NetworkAccessReadOnly
        /// </summary>
        public bool NetworkAccessReadOnly { get; set;}
    }
}