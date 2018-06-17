using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANCommonInterfaceConfig
{
    /// <summary>
    /// result object for GetCommonLinkProperties
    /// </summary>
    public class GetCommonLinkPropertiesResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetCommonLinkPropertiesResult(XDocument soapresult)
        {
            this.WANAccessType = soapresult.Descendants("NewWANAccessType").First().Value;
            this.Layer1UpstreamMaxBitRate = Convert.ToInt32(soapresult.Descendants("NewLayer1UpstreamMaxBitRate").First().Value);
            this.Layer1DownstreamMaxBitRate = Convert.ToInt32(soapresult.Descendants("NewLayer1DownstreamMaxBitRate").First().Value);
            this.PhysicalLinkStatus = soapresult.Descendants("NewPhysicalLinkStatus").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the WANAccessType
        /// </summary>
        public string WANAccessType { get; internal set;}

        /// <summary>
        /// gets or sets the Layer1UpstreamMaxBitRate
        /// </summary>
        public Int32 Layer1UpstreamMaxBitRate { get; internal set;}

        /// <summary>
        /// gets or sets the Layer1DownstreamMaxBitRate
        /// </summary>
        public Int32 Layer1DownstreamMaxBitRate { get; internal set;}

        /// <summary>
        /// gets or sets the PhysicalLinkStatus
        /// </summary>
        public string PhysicalLinkStatus { get; internal set;}

        #endregion
    }
}