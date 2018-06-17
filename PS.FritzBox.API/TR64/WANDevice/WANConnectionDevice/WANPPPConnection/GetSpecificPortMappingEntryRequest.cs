using System;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANPPPConnection
{
    /// <summary>
    /// request object for GetSpecificPortMappingEntry
    /// </summary>
    public class GetSpecificPortMappingEntryRequest
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
    }
}