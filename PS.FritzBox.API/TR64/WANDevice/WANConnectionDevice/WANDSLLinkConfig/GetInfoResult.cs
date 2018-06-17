using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANDSLLinkConfig
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
            this.LinkStatus = (LinkStatus)Enum.Parse(typeof(LinkStatus), soapresult.Descendants("NewLinkStatus").First().Value);
            this.LinkType = (LinkType)Enum.Parse(typeof(LinkType), soapresult.Descendants("NewLinkType").First().Value);
            this.DestinationAddress = soapresult.Descendants("NewDestinationAddress").First().Value;
            this.ATMEncapsulation = (ATMEncapsulation)Enum.Parse(typeof(ATMEncapsulation), soapresult.Descendants("NewATMEncapsulation").First().Value);
            this.AutoConfig = soapresult.Descendants("NewAutoConfig").First().Value == "1";
            this.ATMQoS = soapresult.Descendants("NewATMQoS").First().Value;
            this.ATMPeakCellRate = Convert.ToInt32(soapresult.Descendants("NewATMPeakCellRate").First().Value);
            this.ATMSustainableCellRate = Convert.ToInt32(soapresult.Descendants("NewATMSustainableCellRate").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; internal set;}

        /// <summary>
        /// gets or sets the LinkStatus
        /// </summary>
        public LinkStatus LinkStatus { get; internal set;}

        /// <summary>
        /// gets or sets the LinkType
        /// </summary>
        public LinkType LinkType { get; internal set;}

        /// <summary>
        /// gets or sets the DestinationAddress
        /// </summary>
        public string DestinationAddress { get; internal set;}

        /// <summary>
        /// gets or sets the ATMEncapsulation
        /// </summary>
        public ATMEncapsulation ATMEncapsulation { get; internal set;}

        /// <summary>
        /// gets or sets the AutoConfig
        /// </summary>
        public bool AutoConfig { get; internal set;}

        /// <summary>
        /// gets or sets the ATMQoS
        /// </summary>
        public string ATMQoS { get; internal set;}

        /// <summary>
        /// gets or sets the ATMPeakCellRate
        /// </summary>
        public Int32 ATMPeakCellRate { get; internal set;}

        /// <summary>
        /// gets or sets the ATMSustainableCellRate
        /// </summary>
        public Int32 ATMSustainableCellRate { get; internal set;}

        #endregion
    }
}