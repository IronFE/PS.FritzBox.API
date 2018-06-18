using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for X_AVM_DE_GetIPv6DNSServer
    /// </summary>
    public class X_AVM_DE_GetIPv6DNSServerResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_AVM_DE_GetIPv6DNSServerResult(XDocument soapresult)
        {
            this.IPv6DNSServer1 = soapresult.Descendants("NewIPv6DNSServer1").First().Value;
            this.ValidLifetime1 = Convert.ToInt32(soapresult.Descendants("NewValidLifetime1").First().Value);
            this.IPv6DNSServer2 = soapresult.Descendants("NewIPv6DNSServer2").First().Value;
            this.ValidLifetime = Convert.ToInt32(soapresult.Descendants("NewValidLifetime").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the IPv6DNSServer1
        /// </summary>
        public string IPv6DNSServer1 { get; internal set;}

        /// <summary>
        /// gets or sets the ValidLifetime1
        /// </summary>
        public Int32 ValidLifetime1 { get; internal set;}

        /// <summary>
        /// gets or sets the IPv6DNSServer2
        /// </summary>
        public string IPv6DNSServer2 { get; internal set;}

        /// <summary>
        /// gets or sets the ValidLifetime
        /// </summary>
        public Int32 ValidLifetime { get; internal set;}

        #endregion
    }
}