using System;

namespace PS.FritzBox.API.TR64.LANDevice.Hosts
{
    /// <summary>
    /// request object for X_GetSpecificHostEntryExt
    /// </summary>
    public class X_GetSpecificHostEntryExtRequest
    {
        /// <summary>
        /// gets or sets the MACAddress
        /// </summary>
        public string MACAddress { get; set;}
    }
}