using System;

namespace PS.FritzBox.API.TR64.DeviceInfo
{
    /// <summary>
    /// request object for SetProvisioningCode
    /// </summary>
    public class SetProvisioningCodeRequest
    {
        /// <summary>
        /// gets or sets the ProvisioningCode
        /// </summary>
        public string ProvisioningCode { get; set;}
    }
}