using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.LANDevice
{
    /// <summary>
    /// result object for GetInfo
    /// </summary>
    public class LANEthernetInterfaceConfigResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal LANEthernetInterfaceConfigResult(XDocument soapresult)
        {
            this.Enable = soapresult.Descendants("NewEnable").First().Value == "1";
            this.Status = soapresult.Descendants("NewStatus").First().Value;
            this.MACAddress = soapresult.Descendants("NewMACAddress").First().Value;
            this.MaxBitRate = soapresult.Descendants("NewMaxBitRate").First().Value;
            this.DuplexMode = soapresult.Descendants("NewDuplexMode").First().Value;
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
        /// gets or sets the MACAddress
        /// </summary>
        public string MACAddress { get; internal set;}

        /// <summary>
        /// gets or sets the MaxBitRate
        /// </summary>
        public string MaxBitRate { get; internal set;}

        /// <summary>
        /// gets or sets the DuplexMode
        /// </summary>
        public string DuplexMode { get; internal set;}

        #endregion
    }
}