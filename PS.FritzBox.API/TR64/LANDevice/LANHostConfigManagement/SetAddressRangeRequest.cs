using System;

namespace PS.FritzBox.API.TR64.LANDevice.LANHostConfigManagement
{
    /// <summary>
    /// request object for SetAddressRange
    /// </summary>
    public class SetAddressRangeRequest
    {
        /// <summary>
        /// gets or sets the MinAddress
        /// </summary>
        public string MinAddress { get; set;}

        /// <summary>
        /// gets or sets the MaxAddress
        /// </summary>
        public string MaxAddress { get; set;}
    }
}