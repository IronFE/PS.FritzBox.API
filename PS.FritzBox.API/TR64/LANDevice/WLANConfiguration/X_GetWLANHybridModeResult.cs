using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for X_GetWLANHybridMode
    /// </summary>
    public class X_GetWLANHybridModeResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetWLANHybridModeResult(XDocument soapresult)
        {
            this.Enable = soapresult.Descendants("NewEnable").First().Value == "1";
            this.BeaconType = soapresult.Descendants("NewBeaconType").First().Value;
            this.KeyPassphrase = soapresult.Descendants("NewKeyPassphrase").First().Value;
            this.SSID = soapresult.Descendants("NewSSID").First().Value;
            this.BSSID = soapresult.Descendants("NewBSSID").First().Value;
            this.TrafficMode = soapresult.Descendants("NewTrafficMode").First().Value;
            this.ManualSpeed = soapresult.Descendants("NewManualSpeed").First().Value == "1";
            this.MaxSpeedDS = Convert.ToInt32(soapresult.Descendants("NewMaxSpeedDS").First().Value);
            this.MaxSpeedUS = Convert.ToInt32(soapresult.Descendants("NewMaxSpeedUS").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; internal set;}

        /// <summary>
        /// gets or sets the BeaconType
        /// </summary>
        public string BeaconType { get; internal set;}

        /// <summary>
        /// gets or sets the KeyPassphrase
        /// </summary>
        public string KeyPassphrase { get; internal set;}

        /// <summary>
        /// gets or sets the SSID
        /// </summary>
        public string SSID { get; internal set;}

        /// <summary>
        /// gets or sets the BSSID
        /// </summary>
        public string BSSID { get; internal set;}

        /// <summary>
        /// gets or sets the TrafficMode
        /// </summary>
        public string TrafficMode { get; internal set;}

        /// <summary>
        /// gets or sets the ManualSpeed
        /// </summary>
        public bool ManualSpeed { get; internal set;}

        /// <summary>
        /// gets or sets the MaxSpeedDS
        /// </summary>
        public Int32 MaxSpeedDS { get; internal set;}

        /// <summary>
        /// gets or sets the MaxSpeedUS
        /// </summary>
        public Int32 MaxSpeedUS { get; internal set;}

        #endregion
    }
}