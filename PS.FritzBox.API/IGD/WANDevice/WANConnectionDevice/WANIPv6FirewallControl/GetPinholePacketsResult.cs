using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANIPv6FirewallControl
{
    /// <summary>
    /// result object for GetPinholePackets
    /// </summary>
    public class GetPinholePacketsResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetPinholePacketsResult(XDocument soapresult)
        {
            this.PinholePackets = Convert.ToInt32(soapresult.Descendants("PinholePackets").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the PinholePackets
        /// </summary>
        public Int32 PinholePackets { get; internal set;}

        #endregion
    }
}