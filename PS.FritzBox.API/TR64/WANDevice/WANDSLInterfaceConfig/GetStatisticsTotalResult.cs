using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANDSLInterfaceConfig
{
    /// <summary>
    /// result object for GetStatisticsTotal
    /// </summary>
    public class GetStatisticsTotalResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetStatisticsTotalResult(XDocument soapresult)
        {
            this.ReceiveBlocks = Convert.ToInt32(soapresult.Descendants("NewReceiveBlocks").First().Value);
            this.TransmitBlocks = Convert.ToInt32(soapresult.Descendants("NewTransmitBlocks").First().Value);
            this.CellDelin = Convert.ToInt32(soapresult.Descendants("NewCellDelin").First().Value);
            this.LinkRetrain = Convert.ToInt32(soapresult.Descendants("NewLinkRetrain").First().Value);
            this.InitErrors = Convert.ToInt32(soapresult.Descendants("NewInitErrors").First().Value);
            this.InitTimeouts = Convert.ToInt32(soapresult.Descendants("NewInitTimeouts").First().Value);
            this.LossOfFraming = Convert.ToInt32(soapresult.Descendants("NewLossOfFraming").First().Value);
            this.ErroredSecs = Convert.ToInt32(soapresult.Descendants("NewErroredSecs").First().Value);
            this.SeverelyErroredSecs = Convert.ToInt32(soapresult.Descendants("NewSeverelyErroredSecs").First().Value);
            this.FECErrors = Convert.ToInt32(soapresult.Descendants("NewFECErrors").First().Value);
            this.ATUCFECErrors = Convert.ToInt32(soapresult.Descendants("NewATUCFECErrors").First().Value);
            this.HECErrors = Convert.ToInt32(soapresult.Descendants("NewHECErrors").First().Value);
            this.ATUCHECErrors = Convert.ToInt32(soapresult.Descendants("NewATUCHECErrors").First().Value);
            this.CRCErrors = Convert.ToInt32(soapresult.Descendants("NewCRCErrors").First().Value);
            this.ATUCCRCErrors = Convert.ToInt32(soapresult.Descendants("NewATUCCRCErrors").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ReceiveBlocks
        /// </summary>
        public Int32 ReceiveBlocks { get; internal set;}

        /// <summary>
        /// gets or sets the TransmitBlocks
        /// </summary>
        public Int32 TransmitBlocks { get; internal set;}

        /// <summary>
        /// gets or sets the CellDelin
        /// </summary>
        public Int32 CellDelin { get; internal set;}

        /// <summary>
        /// gets or sets the LinkRetrain
        /// </summary>
        public Int32 LinkRetrain { get; internal set;}

        /// <summary>
        /// gets or sets the InitErrors
        /// </summary>
        public Int32 InitErrors { get; internal set;}

        /// <summary>
        /// gets or sets the InitTimeouts
        /// </summary>
        public Int32 InitTimeouts { get; internal set;}

        /// <summary>
        /// gets or sets the LossOfFraming
        /// </summary>
        public Int32 LossOfFraming { get; internal set;}

        /// <summary>
        /// gets or sets the ErroredSecs
        /// </summary>
        public Int32 ErroredSecs { get; internal set;}

        /// <summary>
        /// gets or sets the SeverelyErroredSecs
        /// </summary>
        public Int32 SeverelyErroredSecs { get; internal set;}

        /// <summary>
        /// gets or sets the FECErrors
        /// </summary>
        public Int32 FECErrors { get; internal set;}

        /// <summary>
        /// gets or sets the ATUCFECErrors
        /// </summary>
        public Int32 ATUCFECErrors { get; internal set;}

        /// <summary>
        /// gets or sets the HECErrors
        /// </summary>
        public Int32 HECErrors { get; internal set;}

        /// <summary>
        /// gets or sets the ATUCHECErrors
        /// </summary>
        public Int32 ATUCHECErrors { get; internal set;}

        /// <summary>
        /// gets or sets the CRCErrors
        /// </summary>
        public Int32 CRCErrors { get; internal set;}

        /// <summary>
        /// gets or sets the ATUCCRCErrors
        /// </summary>
        public Int32 ATUCCRCErrors { get; internal set;}

        #endregion
    }
}