using System;

namespace PS.FritzBox.API.TR64.LANDevice.LANHostConfigManagement
{
    /// <summary>
    /// request object for SetIPInterface
    /// </summary>
    public class SetIPInterfaceRequest
    {
        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; set;}

        /// <summary>
        /// gets or sets the IPAddress
        /// </summary>
        public string IPAddress { get; set;}

        /// <summary>
        /// gets or sets the SubnetMask
        /// </summary>
        public string SubnetMask { get; set;}

        /// <summary>
        /// gets or sets the IPAddressingType
        /// </summary>
        public string IPAddressingType { get; set;}
    }
}