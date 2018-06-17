using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANIPv6FirewallControl
{
    /// <summary>
    /// result object for GetFirewallStatus
    /// </summary>
    public class GetFirewallStatusResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetFirewallStatusResult(XDocument soapresult)
        {
            this.FirewallEnabled = soapresult.Descendants("FirewallEnabled").First().Value == "1";
            this.InboundPinholeAllowed = soapresult.Descendants("InboundPinholeAllowed").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the FirewallEnabled
        /// </summary>
        public bool FirewallEnabled { get; internal set;}

        /// <summary>
        /// gets or sets the InboundPinholeAllowed
        /// </summary>
        public bool InboundPinholeAllowed { get; internal set;}

        #endregion
    }
}