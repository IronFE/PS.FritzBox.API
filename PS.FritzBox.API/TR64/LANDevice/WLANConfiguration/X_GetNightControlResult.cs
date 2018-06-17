using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for X_GetNightControl
    /// </summary>
    public class X_GetNightControlResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetNightControlResult(XDocument soapresult)
        {
            this.NightControl = soapresult.Descendants("NewNightControl").First().Value;
            this.NightTimeControlNoForcedOff = soapresult.Descendants("NewNightTimeControlNoForcedOff").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the NightControl
        /// </summary>
        public string NightControl { get; internal set;}

        /// <summary>
        /// gets or sets the NightTimeControlNoForcedOff
        /// </summary>
        public bool NightTimeControlNoForcedOff { get; internal set;}

        #endregion
    }
}