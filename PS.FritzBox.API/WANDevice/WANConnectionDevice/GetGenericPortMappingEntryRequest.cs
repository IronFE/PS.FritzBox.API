using System;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
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