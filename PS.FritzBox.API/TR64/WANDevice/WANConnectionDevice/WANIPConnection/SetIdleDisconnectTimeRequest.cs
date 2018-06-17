using System;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANIPConnection
{
    /// <summary>
    /// request object for SetIdleDisconnectTime
    /// </summary>
    public class SetIdleDisconnectTimeRequest
    {
        /// <summary>
        /// gets or sets the IdleDisconnectTime
        /// </summary>
        public Int32 IdleDisconnectTime { get; set;}
    }
}