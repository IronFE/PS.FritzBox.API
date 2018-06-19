using System;

namespace PS.FritzBox.API.TR64
{
    /// <summary>
    /// request object for SetForwardingEntryEnable
    /// </summary>
    public class SetForwardingEntryEnableRequest
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

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; set;}
    }
}