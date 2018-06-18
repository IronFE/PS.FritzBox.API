using System;

namespace PS.FritzBox.API.WANDevice
{
    /// <summary>
    /// request object for X_GetOnlineMonitor
    /// </summary>
    public class X_GetOnlineMonitorRequest
    {
        /// <summary>
        /// gets or sets the SyncGroupIndex
        /// </summary>
        public Int32 SyncGroupIndex { get; set;}
    }
}