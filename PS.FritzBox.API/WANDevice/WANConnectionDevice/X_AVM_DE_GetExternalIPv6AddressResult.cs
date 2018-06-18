using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for X_AVM_DE_GetExternalIPv6Address
    /// </summary>
    public class X_AVM_DE_GetExternalIPv6AddressResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_AVM_DE_GetExternalIPv6AddressResult(XDocument soapresult)
        {
            this.ExternalIPv6Address = soapresult.Descendants("NewExternalIPv6Address").First().Value;
            this.PrefixLength = Convert.ToInt32(soapresult.Descendants("NewPrefixLength").First().Value);
            this.ValidLifetime = Convert.ToInt32(soapresult.Descendants("NewValidLifetime").First().Value);
            this.PreferedLifetime = Convert.ToInt32(soapresult.Descendants("NewPreferedLifetime").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ExternalIPv6Address
        /// </summary>
        public string ExternalIPv6Address { get; internal set;}

        /// <summary>
        /// gets or sets the PrefixLength
        /// </summary>
        public Int32 PrefixLength { get; internal set;}

        /// <summary>
        /// gets or sets the ValidLifetime
        /// </summary>
        public Int32 ValidLifetime { get; internal set;}

        /// <summary>
        /// gets or sets the PreferedLifetime
        /// </summary>
        public Int32 PreferedLifetime { get; internal set;}

        #endregion
    }
}