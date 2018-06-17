using System;

namespace PS.FritzBox.API.TR64.ManagementServer
{
    /// <summary>
    /// request object for X_SetTR069Enable
    /// </summary>
    public class X_SetTR069EnableRequest
    {
        /// <summary>
        /// gets or sets the TR069Enabled
        /// </summary>
        public bool TR069Enabled { get; set;}
    }
}