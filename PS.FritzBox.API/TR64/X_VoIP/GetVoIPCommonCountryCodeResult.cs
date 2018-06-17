using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for GetVoIPCommonCountryCode
    /// </summary>
    public class GetVoIPCommonCountryCodeResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetVoIPCommonCountryCodeResult(XDocument soapresult)
        {
            this.VoIPCountryCode = soapresult.Descendants("NewVoIPCountryCode").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the VoIPCountryCode
        /// </summary>
        public string VoIPCountryCode { get; internal set;}

        #endregion
    }
}