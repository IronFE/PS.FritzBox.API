using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.Time
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
            this.NTPServer1 = soapresult.Descendants("NewNTPServer1").First().Value;
            this.NTPServer2 = soapresult.Descendants("NewNTPServer2").First().Value;
            this.CurrentLocalTime = Convert.ToDateTime(soapresult.Descendants("NewCurrentLocalTime").First().Value);
            this.LocalTimeZone = soapresult.Descendants("NewLocalTimeZone").First().Value;
            this.LocalTimeZoneName = soapresult.Descendants("NewLocalTimeZoneName").First().Value;
            this.DaylightSavingsUsed = soapresult.Descendants("NewDaylightSavingsUsed").First().Value == "1";
            this.DaylightSavingsStart = Convert.ToDateTime(soapresult.Descendants("NewDaylightSavingsStart").First().Value);
            this.DaylightSavingsEnd = Convert.ToDateTime(soapresult.Descendants("NewDaylightSavingsEnd").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the NTPServer1
        /// </summary>
        public string NTPServer1 { get; internal set;}

        /// <summary>
        /// gets or sets the NTPServer2
        /// </summary>
        public string NTPServer2 { get; internal set;}

        /// <summary>
        /// gets or sets the CurrentLocalTime
        /// </summary>
        public DateTime CurrentLocalTime { get; internal set;}

        /// <summary>
        /// gets or sets the LocalTimeZone
        /// </summary>
        public string LocalTimeZone { get; internal set;}

        /// <summary>
        /// gets or sets the LocalTimeZoneName
        /// </summary>
        public string LocalTimeZoneName { get; internal set;}

        /// <summary>
        /// gets or sets the DaylightSavingsUsed
        /// </summary>
        public bool DaylightSavingsUsed { get; internal set;}

        /// <summary>
        /// gets or sets the DaylightSavingsStart
        /// </summary>
        public DateTime DaylightSavingsStart { get; internal set;}

        /// <summary>
        /// gets or sets the DaylightSavingsEnd
        /// </summary>
        public DateTime DaylightSavingsEnd { get; internal set;}

        #endregion
    }
}