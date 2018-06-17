using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANConfigSecurity
{
    /// <summary>
    /// result object for X_GetAnonymousLogin
    /// </summary>
    public class X_GetAnonymousLoginResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetAnonymousLoginResult(XDocument soapresult)
        {
            this.AnonymousLoginEnabled = soapresult.Descendants("NewX_AVM-DE_AnonymousLoginEnabled").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the AnonymousLoginEnabled
        /// </summary>
        public bool AnonymousLoginEnabled { get; internal set;}

        #endregion
    }
}