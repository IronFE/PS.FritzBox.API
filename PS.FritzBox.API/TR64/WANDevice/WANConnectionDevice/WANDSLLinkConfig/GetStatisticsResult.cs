using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANDSLLinkConfig
{
    /// <summary>
    /// result object for GetStatistics
    /// </summary>
    public class GetStatisticsResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetStatisticsResult(XDocument soapresult)
        {
            this.ATMTransmittedBlocks = Convert.ToInt32(soapresult.Descendants("NewATMTransmittedBlocks").First().Value);
            this.ATMReceivedBlocks = Convert.ToInt32(soapresult.Descendants("NewATMReceivedBlocks").First().Value);
            this.AAL5CRCErrors = Convert.ToInt32(soapresult.Descendants("NewAAL5CRCErrors").First().Value);
            this.ATMCRCErrors = Convert.ToInt32(soapresult.Descendants("NewATMCRCErrors").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ATMTransmittedBlocks
        /// </summary>
        public Int32 ATMTransmittedBlocks { get; internal set;}

        /// <summary>
        /// gets or sets the ATMReceivedBlocks
        /// </summary>
        public Int32 ATMReceivedBlocks { get; internal set;}

        /// <summary>
        /// gets or sets the AAL5CRCErrors
        /// </summary>
        public Int32 AAL5CRCErrors { get; internal set;}

        /// <summary>
        /// gets or sets the ATMCRCErrors
        /// </summary>
        public Int32 ATMCRCErrors { get; internal set;}

        #endregion
    }
}