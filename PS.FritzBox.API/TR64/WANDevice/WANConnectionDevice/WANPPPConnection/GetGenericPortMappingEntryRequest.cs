using System;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANPPPConnection
{
    /// <summary>
    /// request object for GetGenericPortMappingEntry
    /// </summary>
    public class GetGenericPortMappingEntryRequest
    {
        /// <summary>
        /// gets or sets the PortMappingIndex
        /// </summary>
        public Int32 PortMappingIndex { get; set;}
    }
}