using System;

namespace PS.FritzBox.API.TR64.LANDevice
{
    /// <summary>
    /// request object for GetSpecificHostEntry
    /// </summary>
    public class GetSpecificHostEntryRequest
    {
        /// <summary>
        /// gets or sets the MACAddress
        /// </summary>
        public string MACAddress { get; set;}
    }
}