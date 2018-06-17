using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANIPConnection
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
            this.LastConnectionError = (LastConnectionError)Enum.Parse(typeof(LastConnectionError), soapresult.Descendants("NewLastConnectionError").First().Value);
            this.RSIPAvailable = soapresult.Descendants("NewRSIPAvailable").First().Value == "1";
            this.NATEnabled = soapresult.Descendants("NewNATEnabled").First().Value == "1";
            this.ExternalIPAddress = soapresult.Descendants("NewExternalIPAddress").First().Value;
            this.DNSServers = soapresult.Descendants("NewDNSServers").First().Value;
            this.MACAddress = soapresult.Descendants("NewMACAddress").First().Value;
            this.ConnectionTrigger = soapresult.Descendants("NewConnectionTrigger").First().Value;
            this.RouteProtocolRx = soapresult.Descendants("NewRouteProtocolRx").First().Value;
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
        /// gets or sets the LastConnectionError
        /// </summary>
        public LastConnectionError LastConnectionError { get; internal set;}

        /// <summary>
        /// gets or sets the RSIPAvailable
        /// </summary>
        public bool RSIPAvailable { get; internal set;}

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
        /// gets or sets the RouteProtocolRx
        /// </summary>
        public string RouteProtocolRx { get; internal set;}

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