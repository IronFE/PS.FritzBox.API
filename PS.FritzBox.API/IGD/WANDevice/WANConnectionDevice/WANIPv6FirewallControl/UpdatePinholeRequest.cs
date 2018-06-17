using System;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANIPv6FirewallControl
{
    /// <summary>
    /// request object for UpdatePinhole
    /// </summary>
    public class UpdatePinholeRequest
    {
        /// <summary>
        /// gets or sets the UniqueID
        /// </summary>
        public Int32 UniqueID { get; set;}

        /// <summary>
        /// gets or sets the LeaseTime
        /// </summary>
        public Int32 LeaseTime { get; set;}
    }
}