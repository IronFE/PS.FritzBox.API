using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for X_SetWPSConfig
    /// </summary>
    public class X_SetWPSConfigResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_SetWPSConfigResult(XDocument soapresult)
        {
            this.WPSAPPIN = soapresult.Descendants("NewX_AVM-DE_WPSAPPIN").First().Value;
            this.WPSStatus = soapresult.Descendants("NewX_AVM-DE_WPSStatus").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the WPSAPPIN
        /// </summary>
        public string WPSAPPIN { get; internal set;}

        /// <summary>
        /// gets or sets the WPSStatus
        /// </summary>
        public string WPSStatus { get; internal set;}

        #endregion
    }
}