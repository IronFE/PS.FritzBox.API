using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for GetPacketStatistics
    /// </summary>
    public class GetPacketStatisticsResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetPacketStatisticsResult(XDocument soapresult)
        {
            this.TotalPacketsSent = Convert.ToInt32(soapresult.Descendants("NewTotalPacketsSent").First().Value);
            this.TotalPacketsReceived = Convert.ToInt32(soapresult.Descendants("NewTotalPacketsReceived").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the TotalPacketsSent
        /// </summary>
        public Int32 TotalPacketsSent { get; internal set;}

        /// <summary>
        /// gets or sets the TotalPacketsReceived
        /// </summary>
        public Int32 TotalPacketsReceived { get; internal set;}

        #endregion
    }
}