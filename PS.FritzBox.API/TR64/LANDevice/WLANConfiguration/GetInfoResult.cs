using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for GetInfo
    /// </summary>
    public class GetInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetInfoResult(XDocument soapresult)
        {
            this.Enable = soapresult.Descendants("NewEnable").First().Value == "1";
            this.Status = soapresult.Descendants("NewStatus").First().Value;
            this.MaxBitRate = soapresult.Descendants("NewMaxBitRate").First().Value;
            this.Channel = Convert.ToInt32(soapresult.Descendants("NewChannel").First().Value);
            this.SSID = soapresult.Descendants("NewSSID").First().Value;
            this.BeaconType = soapresult.Descendants("NewBeaconType").First().Value;
            this.MACAddressControlEnabled = soapresult.Descendants("NewMACAddressControlEnabled").First().Value == "1";
            this.Standard = soapresult.Descendants("NewStandard").First().Value;
            this.BSSID = soapresult.Descendants("NewBSSID").First().Value;
            this.BasicEncryptionModes = soapresult.Descendants("NewBasicEncryptionModes").First().Value;
            this.BasicAuthenticationMode = soapresult.Descendants("NewBasicAuthenticationMode").First().Value;
            this.MaxCharsSSID = Convert.ToInt32(soapresult.Descendants("NewMaxCharsSSID").First().Value);
            this.MinCharsSSID = Convert.ToInt32(soapresult.Descendants("NewMinCharsSSID").First().Value);
            this.AllowedCharsSSID = soapresult.Descendants("NewAllowedCharsSSID").First().Value;
            this.MinCharsPSK = Convert.ToInt32(soapresult.Descendants("NewMinCharsPSK").First().Value);
            this.MaxCharsPSK = Convert.ToInt32(soapresult.Descendants("NewMaxCharsPSK").First().Value);
            this.AllowedCharsPSK = soapresult.Descendants("NewAllowedCharsPSK").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; internal set;}

        /// <summary>
        /// gets or sets the Status
        /// </summary>
        public string Status { get; internal set;}

        /// <summary>
        /// gets or sets the MaxBitRate
        /// </summary>
        public string MaxBitRate { get; internal set;}

        /// <summary>
        /// gets or sets the Channel
        /// </summary>
        public Int32 Channel { get; internal set;}

        /// <summary>
        /// gets or sets the SSID
        /// </summary>
        public string SSID { get; internal set;}

        /// <summary>
        /// gets or sets the BeaconType
        /// </summary>
        public string BeaconType { get; internal set;}

        /// <summary>
        /// gets or sets the MACAddressControlEnabled
        /// </summary>
        public bool MACAddressControlEnabled { get; internal set;}

        /// <summary>
        /// gets or sets the Standard
        /// </summary>
        public string Standard { get; internal set;}

        /// <summary>
        /// gets or sets the BSSID
        /// </summary>
        public string BSSID { get; internal set;}

        /// <summary>
        /// gets or sets the BasicEncryptionModes
        /// </summary>
        public string BasicEncryptionModes { get; internal set;}

        /// <summary>
        /// gets or sets the BasicAuthenticationMode
        /// </summary>
        public string BasicAuthenticationMode { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsSSID
        /// </summary>
        public Int32 MaxCharsSSID { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsSSID
        /// </summary>
        public Int32 MinCharsSSID { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsSSID
        /// </summary>
        public string AllowedCharsSSID { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsPSK
        /// </summary>
        public Int32 MinCharsPSK { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsPSK
        /// </summary>
        public Int32 MaxCharsPSK { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsPSK
        /// </summary>
        public string AllowedCharsPSK { get; internal set;}

        #endregion
    }
}