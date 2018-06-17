using System;

namespace PS.FritzBox.API.TR64.LANDevice.LANHostConfigManagement
{
    /// <summary>
    /// request object for SetDHCPServerEnable
    /// </summary>
    public class SetDHCPServerEnableRequest
    {
        /// <summary>
        /// gets or sets the DHCPServerEnable
        /// </summary>
        public bool DHCPServerEnable { get; set;}
    }
}