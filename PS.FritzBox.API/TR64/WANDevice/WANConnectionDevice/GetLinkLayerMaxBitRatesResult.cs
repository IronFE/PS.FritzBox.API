using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for GetLinkLayerMaxBitRates
    /// </summary>
    public class GetLinkLayerMaxBitRatesResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetLinkLayerMaxBitRatesResult(XDocument soapresult)
        {
            this.UpstreamMaxBitRate = Convert.ToInt32(soapresult.Descendants("NewUpstreamMaxBitRate").First().Value);
            this.DownstreamMaxBitRate = Convert.ToInt32(soapresult.Descendants("NewDownstreamMaxBitRate").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the UpstreamMaxBitRate
        /// </summary>
        public Int32 UpstreamMaxBitRate { get; internal set;}

        /// <summary>
        /// gets or sets the DownstreamMaxBitRate
        /// </summary>
        public Int32 DownstreamMaxBitRate { get; internal set;}

        #endregion
    }
}