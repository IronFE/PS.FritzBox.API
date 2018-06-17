using System;

namespace PS.FritzBox.API.TR64.LANDevice.LANHostConfigManagement
{
    /// <summary>
    /// request object for SetSubnetMask
    /// </summary>
    public class SetSubnetMaskRequest
    {
        /// <summary>
        /// gets or sets the SubnetMask
        /// </summary>
        public string SubnetMask { get; set;}
    }
}