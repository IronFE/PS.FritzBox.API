using System;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// request object for GetSpecificAssociatedDeviceInfo
    /// </summary>
    public class GetSpecificAssociatedDeviceInfoRequest
    {
        /// <summary>
        /// gets or sets the AssociatedDeviceMACAddress
        /// </summary>
        public string AssociatedDeviceMACAddress { get; set;}
    }
}