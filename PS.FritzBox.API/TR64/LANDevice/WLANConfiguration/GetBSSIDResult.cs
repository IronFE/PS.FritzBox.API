using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for GetBSSID
    /// </summary>
    public class GetBSSIDResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetBSSIDResult(XDocument soapresult)
        {
            this.BSSID = soapresult.Descendants("NewBSSID").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the BSSID
        /// </summary>
        public string BSSID { get; internal set;}

        #endregion
    }
}