using System;

namespace PS.FritzBox.API.TR64.Layer3Forwarding
{
    /// <summary>
    /// request object for GetGenericForwardingEntry
    /// </summary>
    public class GetGenericForwardingEntryRequest
    {
        /// <summary>
        /// gets or sets the ForwardingIndex
        /// </summary>
        public Int32 ForwardingIndex { get; set;}
    }
}