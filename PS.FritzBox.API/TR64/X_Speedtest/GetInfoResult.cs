using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Speedtest
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
            this.EnableTcp = soapresult.Descendants("NewEnableTcp").First().Value == "1";
            this.EnableUdp = soapresult.Descendants("NewEnableUdp").First().Value == "1";
            this.EnableUdpBidirect = soapresult.Descendants("NewEnableUdpBidirect").First().Value == "1";
            this.WANEnableTcp = soapresult.Descendants("NewWANEnableTcp").First().Value == "1";
            this.WANEnableUdp = soapresult.Descendants("NewWANEnableUdp").First().Value == "1";
            this.PortTcp = Convert.ToInt32(soapresult.Descendants("NewPortTcp").First().Value);
            this.PortUdp = Convert.ToInt32(soapresult.Descendants("NewPortUdp").First().Value);
            this.PortUdpBidirect = Convert.ToInt32(soapresult.Descendants("NewPortUdpBidirect").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the EnableTcp
        /// </summary>
        public bool EnableTcp { get; internal set;}

        /// <summary>
        /// gets or sets the EnableUdp
        /// </summary>
        public bool EnableUdp { get; internal set;}

        /// <summary>
        /// gets or sets the EnableUdpBidirect
        /// </summary>
        public bool EnableUdpBidirect { get; internal set;}

        /// <summary>
        /// gets or sets the WANEnableTcp
        /// </summary>
        public bool WANEnableTcp { get; internal set;}

        /// <summary>
        /// gets or sets the WANEnableUdp
        /// </summary>
        public bool WANEnableUdp { get; internal set;}

        /// <summary>
        /// gets or sets the PortTcp
        /// </summary>
        public Int32 PortTcp { get; internal set;}

        /// <summary>
        /// gets or sets the PortUdp
        /// </summary>
        public Int32 PortUdp { get; internal set;}

        /// <summary>
        /// gets or sets the PortUdpBidirect
        /// </summary>
        public Int32 PortUdpBidirect { get; internal set;}

        #endregion
    }
}