using System;

namespace PS.FritzBox.API.TR64.DeviceConfig
{
    /// <summary>
    /// request object for SetPersistentData
    /// </summary>
    public class SetPersistentDataRequest
    {
        /// <summary>
        /// gets or sets the PersistentData
        /// </summary>
        public string PersistentData { get; set;}
    }
}