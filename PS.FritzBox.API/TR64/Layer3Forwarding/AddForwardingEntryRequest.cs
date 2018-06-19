using System;

namespace PS.FritzBox.API.TR64
{
    /// <summary>
    /// request object for AddForwardingEntry
    /// </summary>
    public class AddForwardingEntryRequest
    {
        /// <summary>
        /// gets or sets the Type
        /// </summary>
        public string Type { get; set;}

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

        /// <summary>
        /// gets or sets the GatewayIPAddress
        /// </summary>
        public string GatewayIPAddress { get; set;}

        /// <summary>
        /// gets or sets the Interface
        /// </summary>
        public string Interface { get; set;}

        /// <summary>
        /// gets or sets the ForwardingMetric
        /// </summary>
        public Int32 ForwardingMetric { get; set;}
    }
}