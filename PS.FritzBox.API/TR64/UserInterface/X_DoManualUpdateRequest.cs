using System;

namespace PS.FritzBox.API.TR64.UserInterface
{
    /// <summary>
    /// request object for X_DoManualUpdate
    /// </summary>
    public class X_DoManualUpdateRequest
    {
        /// <summary>
        /// gets or sets the AllowDowngrade
        /// </summary>
        public bool AllowDowngrade { get; set;}

        /// <summary>
        /// gets or sets the DownloadURL
        /// </summary>
        public string DownloadURL { get; set;}
    }
}