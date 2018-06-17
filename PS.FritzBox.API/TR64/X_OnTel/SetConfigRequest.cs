using System;

namespace PS.FritzBox.API.TR64.X_OnTel
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
        /// gets or sets the Url
        /// </summary>
        public string Url { get; set;}

        /// <summary>
        /// gets or sets the ServiceId
        /// </summary>
        public string ServiceId { get; set;}

        /// <summary>
        /// gets or sets the Username
        /// </summary>
        public string Username { get; set;}

        /// <summary>
        /// gets or sets the Password
        /// </summary>
        public string Password { get; set;}

        /// <summary>
        /// gets or sets the Name
        /// </summary>
        public string Name { get; set;}
    }
}