using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64
{
    /// <summary>
    /// result object for X_GetConfigFile
    /// </summary>
    public class X_GetConfigFileResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetConfigFileResult(XDocument soapresult)
        {
            this.ConfigFileUrl = soapresult.Descendants("NewX_AVM-DE_ConfigFileUrl").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ConfigFileUrl
        /// </summary>
        public string ConfigFileUrl { get; internal set;}

        #endregion
    }
}