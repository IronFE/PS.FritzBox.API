using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for GetEthernetLinkStatus
    /// </summary>
    public class GetEthernetLinkStatusResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetEthernetLinkStatusResult(XDocument soapresult)
        {
            this.EthernetLinkStatus = soapresult.Descendants("NewEthernetLinkStatus").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the EthernetLinkStatus
        /// </summary>
        public string EthernetLinkStatus { get; internal set;}

        #endregion
    }
}