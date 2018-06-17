using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_MyFritz
{
    /// <summary>
    /// result object for GetServiceByIndex
    /// </summary>
    public class GetServiceByIndexResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetServiceByIndexResult(XDocument soapresult)
        {
            this.Enabled = soapresult.Descendants("NewEnabled").First().Value == "1";
            this.Name = soapresult.Descendants("NewName").First().Value;
            this.Scheme = soapresult.Descendants("NewScheme").First().Value;
            this.Port = Convert.ToInt32(soapresult.Descendants("NewPort").First().Value);
            this.URLPath = soapresult.Descendants("NewURLPath").First().Value;
            this.Type = soapresult.Descendants("NewType").First().Value;
            this.IPv4ForwardingWarning = Convert.ToInt32(soapresult.Descendants("NewIPv4ForwardingWarning").First().Value);
            this.IPv4Addresses = soapresult.Descendants("NewIPv4Addresses").First().Value;
            this.IPv6Addresses = soapresult.Descendants("NewIPv6Addresses").First().Value;
            this.IPv6InterfaceIDs = soapresult.Descendants("NewIPv6InterfaceIDs").First().Value;
            this.MACAddress = soapresult.Descendants("NewMACAddress").First().Value;
            this.HostName = soapresult.Descendants("NewHostName").First().Value;
            this.DynDnsLabel = soapresult.Descendants("NewDynDnsLabel").First().Value;
            this.Status = Convert.ToInt32(soapresult.Descendants("NewStatus").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enabled
        /// </summary>
        public bool Enabled { get; internal set;}

        /// <summary>
        /// gets or sets the Name
        /// </summary>
        public string Name { get; internal set;}

        /// <summary>
        /// gets or sets the Scheme
        /// </summary>
        public string Scheme { get; internal set;}

        /// <summary>
        /// gets or sets the Port
        /// </summary>
        public Int32 Port { get; internal set;}

        /// <summary>
        /// gets or sets the URLPath
        /// </summary>
        public string URLPath { get; internal set;}

        /// <summary>
        /// gets or sets the Type
        /// </summary>
        public string Type { get; internal set;}

        /// <summary>
        /// gets or sets the IPv4ForwardingWarning
        /// </summary>
        public Int32 IPv4ForwardingWarning { get; internal set;}

        /// <summary>
        /// gets or sets the IPv4Addresses
        /// </summary>
        public string IPv4Addresses { get; internal set;}

        /// <summary>
        /// gets or sets the IPv6Addresses
        /// </summary>
        public string IPv6Addresses { get; internal set;}

        /// <summary>
        /// gets or sets the IPv6InterfaceIDs
        /// </summary>
        public string IPv6InterfaceIDs { get; internal set;}

        /// <summary>
        /// gets or sets the MACAddress
        /// </summary>
        public string MACAddress { get; internal set;}

        /// <summary>
        /// gets or sets the HostName
        /// </summary>
        public string HostName { get; internal set;}

        /// <summary>
        /// gets or sets the DynDnsLabel
        /// </summary>
        public string DynDnsLabel { get; internal set;}

        /// <summary>
        /// gets or sets the Status
        /// </summary>
        public Int32 Status { get; internal set;}

        #endregion
    }
}