using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANPPPConnection
{
    /// <summary>
    /// result object for GetExternalIPAddress
    /// </summary>
    public class GetExternalIPAddressResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetExternalIPAddressResult(XDocument soapresult)
        {
            this.ExternalIPAddress = soapresult.Descendants("NewExternalIPAddress").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ExternalIPAddress
        /// </summary>
        public string ExternalIPAddress { get; internal set;}

        #endregion
    }
}