using System;

namespace PS.FritzBox.API.TR64
{
    /// <summary>
    /// request object for GetSpecificForwardingEntry
    /// </summary>
    public class GetSpecificForwardingEntryRequest
    {
        /// <summary>
        /// gets or sets the DestIPAddress
        /// </summary>
        public string DestIPAddress { get; set;}

        /// <summary>
        /// gets or sets the DestSubnetMask
        /// </summary>
        public string DestSubnetMask { get; set;}

        /// <summary>
        /// gets or sets the SourceIPAddress
        /// </summary>
        public string SourceIPAddress { get; set;}

        /// <summary>
        /// gets or sets the SourceSubnetMask
        /// </summary>
        public string SourceSubnetMask { get; set;}
    }
}