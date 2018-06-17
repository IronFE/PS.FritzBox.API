using System;

namespace PS.FritzBox.API.TR64.X_Homeplug
{
    /// <summary>
    /// request object for GetSpecificDeviceEntry
    /// </summary>
    public class GetSpecificDeviceEntryRequest
    {
        /// <summary>
        /// gets or sets the MACAddress
        /// </summary>
        public string MACAddress { get; set;}
    }
}