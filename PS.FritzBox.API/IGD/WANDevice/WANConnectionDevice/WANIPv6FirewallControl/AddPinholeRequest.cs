using System;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANIPv6FirewallControl
{
    /// <summary>
    /// request object for AddPinhole
    /// </summary>
    public class AddPinholeRequest
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

        /// <summary>
        /// gets or sets the LeaseTime
        /// </summary>
        public Int32 LeaseTime { get; set;}
    }
}