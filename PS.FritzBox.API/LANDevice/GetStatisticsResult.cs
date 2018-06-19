using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.LANDevice
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
            this.BytesSent = Convert.ToInt32(soapresult.Descendants("NewBytesSent").First().Value);
            this.BytesReceived = Convert.ToInt32(soapresult.Descendants("NewBytesReceived").First().Value);
            this.PacketsSent = Convert.ToInt32(soapresult.Descendants("NewPacketsSent").First().Value);
            this.PacketsReceived = Convert.ToInt32(soapresult.Descendants("NewPacketsReceived").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the BytesSent
        /// </summary>
        public Int32 BytesSent { get; internal set;}

        /// <summary>
        /// gets or sets the BytesReceived
        /// </summary>
        public Int32 BytesReceived { get; internal set;}

        /// <summary>
        /// gets or sets the PacketsSent
        /// </summary>
        public Int32 PacketsSent { get; internal set;}

        /// <summary>
        /// gets or sets the PacketsReceived
        /// </summary>
        public Int32 PacketsReceived { get; internal set;}

        #endregion
    }
}