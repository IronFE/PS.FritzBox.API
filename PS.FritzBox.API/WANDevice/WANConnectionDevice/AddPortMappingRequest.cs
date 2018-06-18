using System;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// request object for AddPortMapping
    /// </summary>
    public class AddPortMappingRequest
    {
        /// <summary>
        /// gets or sets the RemoteHost
        /// </summary>
        public string RemoteHost { get; set;}

        /// <summary>
        /// gets or sets the ExternalPort
        /// </summary>
        public Int32 ExternalPort { get; set;}

        /// <summary>
        /// gets or sets the Protocol
        /// </summary>
        public PortMappingProtocol Protocol { get; set;}

        /// <summary>
        /// gets or sets the InternalPort
        /// </summary>
        public Int32 InternalPort { get; set;}

        /// <summary>
        /// gets or sets the InternalClient
        /// </summary>
        public string InternalClient { get; set;}

        /// <summary>
        /// gets or sets the Enabled
        /// </summary>
        public bool Enabled { get; set;}

        /// <summary>
        /// gets or sets the PortMappingDescription
        /// </summary>
        public string PortMappingDescription { get; set;}

        /// <summary>
        /// gets or sets the LeaseDuration
        /// </summary>
        public Int32 LeaseDuration { get; set;}
    }
}