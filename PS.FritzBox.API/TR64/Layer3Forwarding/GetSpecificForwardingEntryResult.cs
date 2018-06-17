using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.Layer3Forwarding
{
    /// <summary>
    /// result object for GetSpecificForwardingEntry
    /// </summary>
    public class GetSpecificForwardingEntryResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetSpecificForwardingEntryResult(XDocument soapresult)
        {
            this.GatewayIPAddress = soapresult.Descendants("NewGatewayIPAddress").First().Value;
            this.Enable = soapresult.Descendants("NewEnable").First().Value == "1";
            this.Status = soapresult.Descendants("NewStatus").First().Value;
            this.Type = soapresult.Descendants("NewType").First().Value;
            this.Interface = soapresult.Descendants("NewInterface").First().Value;
            this.ForwardingMetric = Convert.ToInt32(soapresult.Descendants("NewForwardingMetric").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the GatewayIPAddress
        /// </summary>
        public string GatewayIPAddress { get; internal set;}

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; internal set;}

        /// <summary>
        /// gets or sets the Status
        /// </summary>
        public string Status { get; internal set;}

        /// <summary>
        /// gets or sets the Type
        /// </summary>
        public string Type { get; internal set;}

        /// <summary>
        /// gets or sets the Interface
        /// </summary>
        public string Interface { get; internal set;}

        /// <summary>
        /// gets or sets the ForwardingMetric
        /// </summary>
        public Int32 ForwardingMetric { get; internal set;}

        #endregion
    }
}