using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for GetBeaconAdvertisement
    /// </summary>
    public class GetBeaconAdvertisementResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetBeaconAdvertisementResult(XDocument soapresult)
        {
            this.BeaconAdvertisementEnabled = soapresult.Descendants("NewBeaconAdvertisementEnabled").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the BeaconAdvertisementEnabled
        /// </summary>
        public bool BeaconAdvertisementEnabled { get; internal set;}

        #endregion
    }
}