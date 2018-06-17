using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANIPConnection
{
    /// <summary>
    /// result object for X_AVM_DE_GetDNSServer
    /// </summary>
    public class X_AVM_DE_GetDNSServerResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_AVM_DE_GetDNSServerResult(XDocument soapresult)
        {
            this.IPv4DNSServer1 = soapresult.Descendants("NewIPv4DNSServer1").First().Value;
            this.IPv4DNSServer2 = soapresult.Descendants("NewIPv4DNSServer2").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the IPv4DNSServer1
        /// </summary>
        public string IPv4DNSServer1 { get; internal set;}

        /// <summary>
        /// gets or sets the IPv4DNSServer2
        /// </summary>
        public string IPv4DNSServer2 { get; internal set;}

        #endregion
    }
}