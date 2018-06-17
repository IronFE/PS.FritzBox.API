using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for GetVoIPEnableCountryCode
    /// </summary>
    public class GetVoIPEnableCountryCodeResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetVoIPEnableCountryCodeResult(XDocument soapresult)
        {
            this.VoIPEnableCountryCode = soapresult.Descendants("NewVoIPEnableCountryCode").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the VoIPEnableCountryCode
        /// </summary>
        public bool VoIPEnableCountryCode { get; internal set;}

        #endregion
    }
}