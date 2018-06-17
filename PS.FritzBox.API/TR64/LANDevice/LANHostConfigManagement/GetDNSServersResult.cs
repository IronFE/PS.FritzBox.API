using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.LANHostConfigManagement
{
    /// <summary>
    /// result object for GetDNSServers
    /// </summary>
    public class GetDNSServersResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetDNSServersResult(XDocument soapresult)
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