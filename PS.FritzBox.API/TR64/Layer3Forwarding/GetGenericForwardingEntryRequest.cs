using System;

namespace PS.FritzBox.API.TR64
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