using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANIPConnection
{
    /// <summary>
    /// result object for GetGenericPortMappingEntry
    /// </summary>
    public class GetGenericPortMappingEntryResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetGenericPortMappingEntryResult(XDocument soapresult)
        {
            this.RemoteHost = soapresult.Descendants("NewRemoteHost").First().Value;
            this.ExternalPort = Convert.ToInt32(soapresult.Descendants("NewExternalPort").First().Value);
            this.Protocol = (PortMappingProtocol)Enum.Parse(typeof(PortMappingProtocol), soapresult.Descendants("NewProtocol").First().Value);
            this.InternalPort = Convert.ToInt32(soapresult.Descendants("NewInternalPort").First().Value);
            this.InternalClient = soapresult.Descendants("NewInternalClient").First().Value;
            this.Enabled = soapresult.Descendants("NewEnabled").First().Value == "1";
            this.PortMappingDescription = soapresult.Descendants("NewPortMappingDescription").First().Value;
            this.LeaseDuration = Convert.ToInt32(soapresult.Descendants("NewLeaseDuration").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the RemoteHost
        /// </summary>
        public string RemoteHost { get; internal set;}

        /// <summary>
        /// gets or sets the ExternalPort
        /// </summary>
        public Int32 ExternalPort { get; internal set;}

        /// <summary>
        /// gets or sets the Protocol
        /// </summary>
        public PortMappingProtocol Protocol { get; internal set;}

        /// <summary>
        /// gets or sets the InternalPort
        /// </summary>
        public Int32 InternalPort { get; internal set;}

        /// <summary>
        /// gets or sets the InternalClient
        /// </summary>
        public string InternalClient { get; internal set;}

        /// <summary>
        /// gets or sets the Enabled
        /// </summary>
        public bool Enabled { get; internal set;}

        /// <summary>
        /// gets or sets the PortMappingDescription
        /// </summary>
        public string PortMappingDescription { get; internal set;}

        /// <summary>
        /// gets or sets the LeaseDuration
        /// </summary>
        public Int32 LeaseDuration { get; internal set;}

        #endregion
    }
}