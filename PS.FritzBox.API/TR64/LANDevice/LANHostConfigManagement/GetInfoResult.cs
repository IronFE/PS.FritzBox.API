using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.LANHostConfigManagement
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
            this.DHCPServerConfigurable = soapresult.Descendants("NewDHCPServerConfigurable").First().Value == "1";
            this.DHCPRelay = soapresult.Descendants("NewDHCPRelay").First().Value == "1";
            this.MinAddress = soapresult.Descendants("NewMinAddress").First().Value;
            this.MaxAddress = soapresult.Descendants("NewMaxAddress").First().Value;
            this.ReservedAddresses = soapresult.Descendants("NewReservedAddresses").First().Value;
            this.DHCPServerEnable = soapresult.Descendants("NewDHCPServerEnable").First().Value == "1";
            this.DNSServers = soapresult.Descendants("NewDNSServers").First().Value;
            this.DomainName = soapresult.Descendants("NewDomainName").First().Value;
            this.IPRouters = soapresult.Descendants("NewIPRouters").First().Value;
            this.SubnetMask = soapresult.Descendants("NewSubnetMask").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the DHCPServerConfigurable
        /// </summary>
        public bool DHCPServerConfigurable { get; internal set;}

        /// <summary>
        /// gets or sets the DHCPRelay
        /// </summary>
        public bool DHCPRelay { get; internal set;}

        /// <summary>
        /// gets or sets the MinAddress
        /// </summary>
        public string MinAddress { get; internal set;}

        /// <summary>
        /// gets or sets the MaxAddress
        /// </summary>
        public string MaxAddress { get; internal set;}

        /// <summary>
        /// gets or sets the ReservedAddresses
        /// </summary>
        public string ReservedAddresses { get; internal set;}

        /// <summary>
        /// gets or sets the DHCPServerEnable
        /// </summary>
        public bool DHCPServerEnable { get; internal set;}

        /// <summary>
        /// gets or sets the DNSServers
        /// </summary>
        public string DNSServers { get; internal set;}

        /// <summary>
        /// gets or sets the DomainName
        /// </summary>
        public string DomainName { get; internal set;}

        /// <summary>
        /// gets or sets the IPRouters
        /// </summary>
        public string IPRouters { get; internal set;}

        /// <summary>
        /// gets or sets the SubnetMask
        /// </summary>
        public string SubnetMask { get; internal set;}

        #endregion
    }
}