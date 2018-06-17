using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANConfigSecurity
{
    /// <summary>
    /// result object for X_GetCurrentUser
    /// </summary>
    public class X_GetCurrentUserResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetCurrentUserResult(XDocument soapresult)
        {
            this.CurrentUsername = soapresult.Descendants("NewX_AVM-DE_CurrentUsername").First().Value;
            this.CurrentUserRights = soapresult.Descendants("NewX_AVM-DE_CurrentUserRights").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the CurrentUsername
        /// </summary>
        public string CurrentUsername { get; internal set;}

        /// <summary>
        /// gets or sets the CurrentUserRights
        /// </summary>
        public string CurrentUserRights { get; internal set;}

        #endregion
    }
}