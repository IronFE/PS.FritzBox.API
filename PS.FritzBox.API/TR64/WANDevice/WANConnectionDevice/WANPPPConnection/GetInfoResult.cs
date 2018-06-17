using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANPPPConnection
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
            this.ConnectionStatus = (ConnectionStatus)Enum.Parse(typeof(ConnectionStatus), soapresult.Descendants("NewConnectionStatus").First().Value);
            this.PossibleConnectionTypes = (PossibleConnectionTypes)Enum.Parse(typeof(PossibleConnectionTypes), soapresult.Descendants("NewPossibleConnectionTypes").First().Value);
            this.ConnectionType = (ConnectionType)Enum.Parse(typeof(ConnectionType), soapresult.Descendants("NewConnectionType").First().Value);
            this.Name = soapresult.Descendants("NewName").First().Value;
            this.Uptime = Convert.ToInt32(soapresult.Descendants("NewUptime").First().Value);
            this.UpstreamMaxBitRate = Convert.ToInt32(soapresult.Descendants("NewUpstreamMaxBitRate").First().Value);
            this.DownstreamMaxBitRate = Convert.ToInt32(soapresult.Descendants("NewDownstreamMaxBitRate").First().Value);
            this.LastConnectionError = (LastConnectionError)Enum.Parse(typeof(LastConnectionError), soapresult.Descendants("NewLastConnectionError").First().Value);
            this.IdleDisconnectTime = Convert.ToInt32(soapresult.Descendants("NewIdleDisconnectTime").First().Value);
            this.RSIPAvailable = soapresult.Descendants("NewRSIPAvailable").First().Value == "1";
            this.UserName = soapresult.Descendants("NewUserName").First().Value;
            this.NATEnabled = soapresult.Descendants("NewNATEnabled").First().Value == "1";
            this.ExternalIPAddress = soapresult.Descendants("NewExternalIPAddress").First().Value;
            this.DNSServers = soapresult.Descendants("NewDNSServers").First().Value;
            this.MACAddress = soapresult.Descendants("NewMACAddress").First().Value;
            this.ConnectionTrigger = soapresult.Descendants("NewConnectionTrigger").First().Value;
            this.LastAuthErrorInfo = soapresult.Descendants("NewLastAuthErrorInfo").First().Value;
            this.MaxCharsUsername = Convert.ToInt32(soapresult.Descendants("NewMaxCharsUsername").First().Value);
            this.MinCharsUsername = Convert.ToInt32(soapresult.Descendants("NewMinCharsUsername").First().Value);
            this.AllowedCharsUsername = soapresult.Descendants("NewAllowedCharsUsername").First().Value;
            this.MaxCharsPassword = Convert.ToInt32(soapresult.Descendants("NewMaxCharsPassword").First().Value);
            this.MinCharsPassword = Convert.ToInt32(soapresult.Descendants("NewMinCharsPassword").First().Value);
            this.AllowedCharsPassword = soapresult.Descendants("NewAllowedCharsPassword").First().Value;
            this.TransportType = soapresult.Descendants("NewTransportType").First().Value;
            this.RouteProtocolRx = soapresult.Descendants("NewRouteProtocolRx").First().Value;
            this.PPPoEServiceName = soapresult.Descendants("NewPPPoEServiceName").First().Value;
            this.RemoteIPAddress = soapresult.Descendants("NewRemoteIPAddress").First().Value;
            this.PPPoEACName = soapresult.Descendants("NewPPPoEACName").First().Value;
            this.DNSEnabled = soapresult.Descendants("NewDNSEnabled").First().Value == "1";
            this.DNSOverrideAllowed = soapresult.Descendants("NewDNSOverrideAllowed").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; internal set;}

        /// <summary>
        /// gets or sets the ConnectionStatus
        /// </summary>
        public ConnectionStatus ConnectionStatus { get; internal set;}

        /// <summary>
        /// gets or sets the PossibleConnectionTypes
        /// </summary>
        public PossibleConnectionTypes PossibleConnectionTypes { get; internal set;}

        /// <summary>
        /// gets or sets the ConnectionType
        /// </summary>
        public ConnectionType ConnectionType { get; internal set;}

        /// <summary>
        /// gets or sets the Name
        /// </summary>
        public string Name { get; internal set;}

        /// <summary>
        /// gets or sets the Uptime
        /// </summary>
        public Int32 Uptime { get; internal set;}

        /// <summary>
        /// gets or sets the UpstreamMaxBitRate
        /// </summary>
        public Int32 UpstreamMaxBitRate { get; internal set;}

        /// <summary>
        /// gets or sets the DownstreamMaxBitRate
        /// </summary>
        public Int32 DownstreamMaxBitRate { get; internal set;}

        /// <summary>
        /// gets or sets the LastConnectionError
        /// </summary>
        public LastConnectionError LastConnectionError { get; internal set;}

        /// <summary>
        /// gets or sets the IdleDisconnectTime
        /// </summary>
        public Int32 IdleDisconnectTime { get; internal set;}

        /// <summary>
        /// gets or sets the RSIPAvailable
        /// </summary>
        public bool RSIPAvailable { get; internal set;}

        /// <summary>
        /// gets or sets the UserName
        /// </summary>
        public string UserName { get; internal set;}

        /// <summary>
        /// gets or sets the NATEnabled
        /// </summary>
        public bool NATEnabled { get; internal set;}

        /// <summary>
        /// gets or sets the ExternalIPAddress
        /// </summary>
        public string ExternalIPAddress { get; internal set;}

        /// <summary>
        /// gets or sets the DNSServers
        /// </summary>
        public string DNSServers { get; internal set;}

        /// <summary>
        /// gets or sets the MACAddress
        /// </summary>
        public string MACAddress { get; internal set;}

        /// <summary>
        /// gets or sets the ConnectionTrigger
        /// </summary>
        public string ConnectionTrigger { get; internal set;}

        /// <summary>
        /// gets or sets the LastAuthErrorInfo
        /// </summary>
        public string LastAuthErrorInfo { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsUsername
        /// </summary>
        public Int32 MaxCharsUsername { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsUsername
        /// </summary>
        public Int32 MinCharsUsername { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsUsername
        /// </summary>
        public string AllowedCharsUsername { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsPassword
        /// </summary>
        public Int32 MaxCharsPassword { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsPassword
        /// </summary>
        public Int32 MinCharsPassword { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsPassword
        /// </summary>
        public string AllowedCharsPassword { get; internal set;}

        /// <summary>
        /// gets or sets the TransportType
        /// </summary>
        public string TransportType { get; internal set;}

        /// <summary>
        /// gets or sets the RouteProtocolRx
        /// </summary>
        public string RouteProtocolRx { get; internal set;}

        /// <summary>
        /// gets or sets the PPPoEServiceName
        /// </summary>
        public string PPPoEServiceName { get; internal set;}

        /// <summary>
        /// gets or sets the RemoteIPAddress
        /// </summary>
        public string RemoteIPAddress { get; internal set;}

        /// <summary>
        /// gets or sets the PPPoEACName
        /// </summary>
        public string PPPoEACName { get; internal set;}

        /// <summary>
        /// gets or sets the DNSEnabled
        /// </summary>
        public bool DNSEnabled { get; internal set;}

        /// <summary>
        /// gets or sets the DNSOverrideAllowed
        /// </summary>
        public bool DNSOverrideAllowed { get; internal set;}

        #endregion
    }
}