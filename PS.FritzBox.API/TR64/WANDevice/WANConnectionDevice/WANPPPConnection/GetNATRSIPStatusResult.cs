using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANPPPConnection
{
    /// <summary>
    /// result object for GetNATRSIPStatus
    /// </summary>
    public class GetNATRSIPStatusResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetNATRSIPStatusResult(XDocument soapresult)
        {
            this.RSIPAvailable = soapresult.Descendants("NewRSIPAvailable").First().Value == "1";
            this.NATEnabled = soapresult.Descendants("NewNATEnabled").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the RSIPAvailable
        /// </summary>
        public bool RSIPAvailable { get; internal set;}

        /// <summary>
        /// gets or sets the NATEnabled
        /// </summary>
        public bool NATEnabled { get; internal set;}

        #endregion
    }
}