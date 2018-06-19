using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.LANDevice
{
    /// <summary>
    /// result object for X_GetAutoWakeOnLANByMACAddress
    /// </summary>
    public class X_GetAutoWakeOnLANByMACAddressResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetAutoWakeOnLANByMACAddressResult(XDocument soapresult)
        {
            this.AutoWOLEnabled = soapresult.Descendants("NewAutoWOLEnabled").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the AutoWOLEnabled
        /// </summary>
        public bool AutoWOLEnabled { get; internal set;}

        #endregion
    }
}