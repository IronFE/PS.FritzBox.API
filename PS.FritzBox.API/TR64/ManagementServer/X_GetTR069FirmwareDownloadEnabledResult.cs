using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.ManagementServer
{
    /// <summary>
    /// result object for X_GetTR069FirmwareDownloadEnabled
    /// </summary>
    public class X_GetTR069FirmwareDownloadEnabledResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetTR069FirmwareDownloadEnabledResult(XDocument soapresult)
        {
            this.TR069FirmwareDownloadEnabled = soapresult.Descendants("NewTR069FirmwareDownloadEnabled").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the TR069FirmwareDownloadEnabled
        /// </summary>
        public bool TR069FirmwareDownloadEnabled { get; internal set;}

        #endregion
    }
}