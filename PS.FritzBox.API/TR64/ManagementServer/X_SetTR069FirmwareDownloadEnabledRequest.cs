using System;

namespace PS.FritzBox.API.TR64.ManagementServer
{
    /// <summary>
    /// request object for X_SetTR069FirmwareDownloadEnabled
    /// </summary>
    public class X_SetTR069FirmwareDownloadEnabledRequest
    {
        /// <summary>
        /// gets or sets the TR069FirmwareDownloadEnabled
        /// </summary>
        public bool TR069FirmwareDownloadEnabled { get; set;}
    }
}