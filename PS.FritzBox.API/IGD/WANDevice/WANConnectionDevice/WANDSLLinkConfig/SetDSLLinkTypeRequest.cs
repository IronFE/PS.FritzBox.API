using System;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANDSLLinkConfig
{
    /// <summary>
    /// request object for SetDSLLinkType
    /// </summary>
    public class SetDSLLinkTypeRequest
    {
        /// <summary>
        /// gets or sets the LinkType
        /// </summary>
        public LinkType LinkType { get; set;}
    }
}