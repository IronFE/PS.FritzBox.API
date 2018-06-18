using System;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
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