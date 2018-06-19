using System;

namespace PS.FritzBox.API
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