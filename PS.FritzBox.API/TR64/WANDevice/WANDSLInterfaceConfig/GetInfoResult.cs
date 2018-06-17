using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANDSLInterfaceConfig
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
            this.DataPath = soapresult.Descendants("NewDataPath").First().Value;
            this.UpstreamCurrRate = Convert.ToInt32(soapresult.Descendants("NewUpstreamCurrRate").First().Value);
            this.DownstreamCurrRate = Convert.ToInt32(soapresult.Descendants("NewDownstreamCurrRate").First().Value);
            this.UpstreamMaxRate = Convert.ToInt32(soapresult.Descendants("NewUpstreamMaxRate").First().Value);
            this.DownstreamMaxRate = Convert.ToInt32(soapresult.Descendants("NewDownstreamMaxRate").First().Value);
            this.UpstreamNoiseMargin = Convert.ToInt32(soapresult.Descendants("NewUpstreamNoiseMargin").First().Value);
            this.DownstreamNoiseMargin = Convert.ToInt32(soapresult.Descendants("NewDownstreamNoiseMargin").First().Value);
            this.UpstreamAttenuation = Convert.ToInt32(soapresult.Descendants("NewUpstreamAttenuation").First().Value);
            this.DownstreamAttenuation = Convert.ToInt32(soapresult.Descendants("NewDownstreamAttenuation").First().Value);
            this.ATURVendor = soapresult.Descendants("NewATURVendor").First().Value;
            this.ATURCountry = soapresult.Descendants("NewATURCountry").First().Value;
            this.UpstreamPower = Convert.ToInt32(soapresult.Descendants("NewUpstreamPower").First().Value);
            this.DownstreamPower = Convert.ToInt32(soapresult.Descendants("NewDownstreamPower").First().Value);
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
        /// gets or sets the DataPath
        /// </summary>
        public string DataPath { get; internal set;}

        /// <summary>
        /// gets or sets the UpstreamCurrRate
        /// </summary>
        public Int32 UpstreamCurrRate { get; internal set;}

        /// <summary>
        /// gets or sets the DownstreamCurrRate
        /// </summary>
        public Int32 DownstreamCurrRate { get; internal set;}

        /// <summary>
        /// gets or sets the UpstreamMaxRate
        /// </summary>
        public Int32 UpstreamMaxRate { get; internal set;}

        /// <summary>
        /// gets or sets the DownstreamMaxRate
        /// </summary>
        public Int32 DownstreamMaxRate { get; internal set;}

        /// <summary>
        /// gets or sets the UpstreamNoiseMargin
        /// </summary>
        public Int32 UpstreamNoiseMargin { get; internal set;}

        /// <summary>
        /// gets or sets the DownstreamNoiseMargin
        /// </summary>
        public Int32 DownstreamNoiseMargin { get; internal set;}

        /// <summary>
        /// gets or sets the UpstreamAttenuation
        /// </summary>
        public Int32 UpstreamAttenuation { get; internal set;}

        /// <summary>
        /// gets or sets the DownstreamAttenuation
        /// </summary>
        public Int32 DownstreamAttenuation { get; internal set;}

        /// <summary>
        /// gets or sets the ATURVendor
        /// </summary>
        public string ATURVendor { get; internal set;}

        /// <summary>
        /// gets or sets the ATURCountry
        /// </summary>
        public string ATURCountry { get; internal set;}

        /// <summary>
        /// gets or sets the UpstreamPower
        /// </summary>
        public Int32 UpstreamPower { get; internal set;}

        /// <summary>
        /// gets or sets the DownstreamPower
        /// </summary>
        public Int32 DownstreamPower { get; internal set;}

        #endregion
    }
}