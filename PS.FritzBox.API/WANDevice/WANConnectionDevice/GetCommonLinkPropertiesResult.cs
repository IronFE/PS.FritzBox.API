using PS.FritzBox.API.WANDevice;
using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice
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
            this.WANAccessType = (WANAccessType)Enum.Parse(typeof(WANAccessType), soapresult.Descendants("NewWANAccessType").First().Value, true);
            this.Layer1UpstreamMaxBitRate = Convert.ToInt32(soapresult.Descendants("NewLayer1UpstreamMaxBitRate").First().Value);
            this.Layer1DownstreamMaxBitRate = Convert.ToInt32(soapresult.Descendants("NewLayer1DownstreamMaxBitRate").First().Value);
            this.PhysicalLinkStatus = (PhysicalLinkStatus)Enum.Parse(typeof(PhysicalLinkStatus), soapresult.Descendants("NewPhysicalLinkStatus").First().Value, true);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the WANAccessType
        /// </summary>
        public WANAccessType WANAccessType { get; internal set;}

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
        public PhysicalLinkStatus PhysicalLinkStatus { get; internal set;}

        #endregion
    }
}