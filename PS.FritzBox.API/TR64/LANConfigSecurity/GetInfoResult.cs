using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANConfigSecurity
{
    /// <summary>
    /// result object for GetInfo
    /// </summary>
    public class GetInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetInfoResult(XDocument soapresult)
        {
            this.MaxCharsPassword = Convert.ToInt32(soapresult.Descendants("NewMaxCharsPassword").First().Value);
            this.MinCharsPassword = Convert.ToInt32(soapresult.Descendants("NewMinCharsPassword").First().Value);
            this.AllowedCharsPassword = soapresult.Descendants("NewAllowedCharsPassword").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the MaxCharsPassword
        /// </summary>
        public Int32 MaxCharsPassword { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsPassword
        /// </summary>
        public Int32 MinCharsPassword { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsPassword
        /// </summary>
        public string AllowedCharsPassword { get; internal set;}

        #endregion
    }
}