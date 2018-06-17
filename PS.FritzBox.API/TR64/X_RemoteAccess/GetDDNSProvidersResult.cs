using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_RemoteAccess
{
    /// <summary>
    /// result object for GetDDNSProviders
    /// </summary>
    public class GetDDNSProvidersResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetDDNSProvidersResult(XDocument soapresult)
        {
            this.ProviderList = soapresult.Descendants("NewProviderList").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ProviderList
        /// </summary>
        public string ProviderList { get; internal set;}

        #endregion
    }
}