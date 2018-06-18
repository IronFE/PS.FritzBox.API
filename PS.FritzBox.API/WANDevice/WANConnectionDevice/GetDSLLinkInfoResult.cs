using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for GetDSLLinkInfo
    /// </summary>
    public class GetDSLLinkInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetDSLLinkInfoResult(XDocument soapresult)
        {
            this.LinkType = (LinkType)Enum.Parse(typeof(LinkType), soapresult.Descendants("NewLinkType").First().Value, true);
            this.LinkStatus = (LinkStatus)Enum.Parse(typeof(LinkStatus), soapresult.Descendants("NewLinkStatus").First().Value, true);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the LinkType
        /// </summary>
        public LinkType LinkType { get; internal set;}

        /// <summary>
        /// gets or sets the LinkStatus
        /// </summary>
        public LinkStatus LinkStatus { get; internal set;}

        #endregion
    }
}