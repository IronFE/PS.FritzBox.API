using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for GetBasBeaconSecurityProperties
    /// </summary>
    public class GetBasBeaconSecurityPropertiesResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetBasBeaconSecurityPropertiesResult(XDocument soapresult)
        {
            this.BasicEncryptionModes = soapresult.Descendants("NewBasicEncryptionModes").First().Value;
            this.BasicAuthenticationMode = soapresult.Descendants("NewBasicAuthenticationMode").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the BasicEncryptionModes
        /// </summary>
        public string BasicEncryptionModes { get; internal set;}

        /// <summary>
        /// gets or sets the BasicAuthenticationMode
        /// </summary>
        public string BasicAuthenticationMode { get; internal set;}

        #endregion
    }
}