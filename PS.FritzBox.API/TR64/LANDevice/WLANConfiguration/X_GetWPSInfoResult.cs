using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for X_GetWPSInfo
    /// </summary>
    public class X_GetWPSInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetWPSInfoResult(XDocument soapresult)
        {
            this.WPSMode = soapresult.Descendants("NewX_AVM-DE_WPSMode").First().Value;
            this.WPSStatus = soapresult.Descendants("NewX_AVM-DE_WPSStatus").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the WPSMode
        /// </summary>
        public string WPSMode { get; internal set;}

        /// <summary>
        /// gets or sets the WPSStatus
        /// </summary>
        public string WPSStatus { get; internal set;}

        #endregion
    }
}