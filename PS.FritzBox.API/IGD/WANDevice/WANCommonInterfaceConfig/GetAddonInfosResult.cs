using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANCommonInterfaceConfig
{
    /// <summary>
    /// result object for GetAddonInfos
    /// </summary>
    public class GetAddonInfosResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetAddonInfosResult(XDocument soapresult)
        {
            this.ByteSendRate = Convert.ToInt32(soapresult.Descendants("NewByteSendRate").First().Value);
            this.ByteReceiveRate = Convert.ToInt32(soapresult.Descendants("NewByteReceiveRate").First().Value);
            this.PacketSendRate = Convert.ToInt32(soapresult.Descendants("NewPacketSendRate").First().Value);
            this.PacketReceiveRate = Convert.ToInt32(soapresult.Descendants("NewPacketReceiveRate").First().Value);
            this.TotalBytesSent = Convert.ToInt32(soapresult.Descendants("NewTotalBytesSent").First().Value);
            this.TotalBytesReceived = Convert.ToInt32(soapresult.Descendants("NewTotalBytesReceived").First().Value);
            this.AutoDisconnectTime = Convert.ToInt32(soapresult.Descendants("NewAutoDisconnectTime").First().Value);
            this.IdleDisconnectTime = Convert.ToInt32(soapresult.Descendants("NewIdleDisconnectTime").First().Value);
            this.DNSServer1 = soapresult.Descendants("NewDNSServer1").First().Value;
            this.DNSServer2 = soapresult.Descendants("NewDNSServer2").First().Value;
            this.VoipDNSServer1 = soapresult.Descendants("NewVoipDNSServer1").First().Value;
            this.VoipDNSServer2 = soapresult.Descendants("NewVoipDNSServer2").First().Value;
            this.UpnpControlEnabled = soapresult.Descendants("NewUpnpControlEnabled").First().Value == "1";
            this.RoutedBridgedModeBoth = Convert.ToInt32(soapresult.Descendants("NewRoutedBridgedModeBoth").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ByteSendRate
        /// </summary>
        public Int32 ByteSendRate { get; internal set;}

        /// <summary>
        /// gets or sets the ByteReceiveRate
        /// </summary>
        public Int32 ByteReceiveRate { get; internal set;}

        /// <summary>
        /// gets or sets the PacketSendRate
        /// </summary>
        public Int32 PacketSendRate { get; internal set;}

        /// <summary>
        /// gets or sets the PacketReceiveRate
        /// </summary>
        public Int32 PacketReceiveRate { get; internal set;}

        /// <summary>
        /// gets or sets the TotalBytesSent
        /// </summary>
        public Int32 TotalBytesSent { get; internal set;}

        /// <summary>
        /// gets or sets the TotalBytesReceived
        /// </summary>
        public Int32 TotalBytesReceived { get; internal set;}

        /// <summary>
        /// gets or sets the AutoDisconnectTime
        /// </summary>
        public Int32 AutoDisconnectTime { get; internal set;}

        /// <summary>
        /// gets or sets the IdleDisconnectTime
        /// </summary>
        public Int32 IdleDisconnectTime { get; internal set;}

        /// <summary>
        /// gets or sets the DNSServer1
        /// </summary>
        public string DNSServer1 { get; internal set;}

        /// <summary>
        /// gets or sets the DNSServer2
        /// </summary>
        public string DNSServer2 { get; internal set;}

        /// <summary>
        /// gets or sets the VoipDNSServer1
        /// </summary>
        public string VoipDNSServer1 { get; internal set;}

        /// <summary>
        /// gets or sets the VoipDNSServer2
        /// </summary>
        public string VoipDNSServer2 { get; internal set;}

        /// <summary>
        /// gets or sets the UpnpControlEnabled
        /// </summary>
        public bool UpnpControlEnabled { get; internal set;}

        /// <summary>
        /// gets or sets the RoutedBridgedModeBoth
        /// </summary>
        public Int32 RoutedBridgedModeBoth { get; internal set;}

        #endregion
    }
}