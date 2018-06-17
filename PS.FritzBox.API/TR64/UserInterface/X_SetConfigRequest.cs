using System;

namespace PS.FritzBox.API.TR64.UserInterface
{
    /// <summary>
    /// request object for X_SetConfig
    /// </summary>
    public class X_SetConfigRequest
    {
        /// <summary>
        /// gets or sets the AutoUpdateMode
        /// </summary>
        public AutoUpdateMode AutoUpdateMode { get; set;}
    }
}