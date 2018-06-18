using System;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// request object for GetOutboundPinholeTimeout
    /// </summary>
    public class GetOutboundPinholeTimeoutRequest
    {
        /// <summary>
        /// gets or sets the RemoteHost
        /// </summary>
        public string RemoteHost { get; set;}

        /// <summary>
        /// gets or sets the RemotePort
        /// </summary>
        public Int32 RemotePort { get; set;}

        /// <summary>
        /// gets or sets the InternalClient
        /// </summary>
        public string InternalClient { get; set;}

        /// <summary>
        /// gets or sets the InternalPort
        /// </summary>
        public Int32 InternalPort { get; set;}

        /// <summary>
        /// gets or sets the Protocol
        /// </summary>
        public Int32 Protocol { get; set;}
    }
}