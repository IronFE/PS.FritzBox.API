using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANPPPConnection
{
    /// <summary>
    /// result object for X_GetDNSServers
    /// </summary>
    public class X_GetDNSServersResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetDNSServersResult(XDocument soapresult)
        {
            this.DNSServers = soapresult.Descendants("NewDNSServers").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the DNSServers
        /// </summary>
        public string DNSServers { get; internal set;}

        #endregion
    }
}