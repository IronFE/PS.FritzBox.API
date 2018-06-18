using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for GetOutboundPinholeTimeout
    /// </summary>
    public class GetOutboundPinholeTimeoutResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetOutboundPinholeTimeoutResult(XDocument soapresult)
        {
            this.OutboundPinholeTimeout = Convert.ToInt32(soapresult.Descendants("OutboundPinholeTimeout").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the OutboundPinholeTimeout
        /// </summary>
        public Int32 OutboundPinholeTimeout { get; internal set;}

        #endregion
    }
}