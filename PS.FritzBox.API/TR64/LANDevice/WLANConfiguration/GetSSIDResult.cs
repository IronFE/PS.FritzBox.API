using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for GetSSID
    /// </summary>
    public class GetSSIDResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetSSIDResult(XDocument soapresult)
        {
            this.SSID = soapresult.Descendants("NewSSID").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the SSID
        /// </summary>
        public string SSID { get; internal set;}

        #endregion
    }
}