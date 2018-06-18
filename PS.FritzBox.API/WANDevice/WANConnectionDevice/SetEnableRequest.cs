using System;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// request object for SetEnable
    /// </summary>
    public class SetEnableRequest
    {
        /// <summary>
        /// gets or sets the Index
        /// </summary>
        public Int32 Index { get; set; }

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; set;}
    }
}