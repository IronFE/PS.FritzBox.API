using System;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// request object for X_SetAutoDisconnectTimeSpan
    /// </summary>
    public class X_SetAutoDisconnectTimeSpanRequest
    {
        /// <summary>
        /// gets or sets the DisconnectPreventionEnable
        /// </summary>
        public bool DisconnectPreventionEnable { get; set;}

        /// <summary>
        /// gets or sets the DisconnectPreventionHour
        /// </summary>
        public Int32 DisconnectPreventionHour { get; set;}
    }
}