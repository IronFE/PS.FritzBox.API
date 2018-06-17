using System;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// request object for GetGenericAssociatedDeviceInfo
    /// </summary>
    public class GetGenericAssociatedDeviceInfoRequest
    {
        /// <summary>
        /// gets or sets the AssociatedDeviceIndex
        /// </summary>
        public Int32 AssociatedDeviceIndex { get; set;}
    }
}