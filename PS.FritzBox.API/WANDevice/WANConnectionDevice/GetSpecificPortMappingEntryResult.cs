using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for GetSpecificPortMappingEntry
    /// </summary>
    public class GetSpecificPortMappingEntryResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetSpecificPortMappingEntryResult(XDocument soapresult)
        {
            this.InternalPort = Convert.ToInt32(soapresult.Descendants("NewInternalPort").First().Value);
            this.InternalClient = soapresult.Descendants("NewInternalClient").First().Value;
            this.Enabled = soapresult.Descendants("NewEnabled").First().Value == "1";
            this.PortMappingDescription = soapresult.Descendants("NewPortMappingDescription").First().Value;
            this.LeaseDuration = Convert.ToInt32(soapresult.Descendants("NewLeaseDuration").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the InternalPort
        /// </summary>
        public Int32 InternalPort { get; internal set; }

        /// <summary>
        /// gets or sets the InternalClient
        /// </summary>
        public string InternalClient { get; internal set; }

        /// <summary>
        /// gets or sets the Enabled
        /// </summary>
        public bool Enabled { get; internal set; }

        /// <summary>
        /// gets or sets the PortMappingDescription
        /// </summary>
        public string PortMappingDescription { get; internal set; }

        /// <summary>
        /// gets or sets the LeaseDuration
        /// </summary>
        public Int32 LeaseDuration { get; internal set; }

        #endregion
    }
}
