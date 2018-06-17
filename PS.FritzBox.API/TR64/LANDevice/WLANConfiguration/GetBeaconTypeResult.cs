using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for GetBeaconType
    /// </summary>
    public class GetBeaconTypeResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetBeaconTypeResult(XDocument soapresult)
        {
            this.BeaconType = soapresult.Descendants("NewBeaconType").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the BeaconType
        /// </summary>
        public string BeaconType { get; internal set;}

        #endregion
    }
}