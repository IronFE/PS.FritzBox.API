using System;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// request object for SetDefaultWEPKeyIndex
    /// </summary>
    public class SetDefaultWEPKeyIndexRequest
    {
        /// <summary>
        /// gets or sets the DefaultWEPKeyIndex
        /// </summary>
        public Int32 DefaultWEPKeyIndex { get; set;}
    }
}