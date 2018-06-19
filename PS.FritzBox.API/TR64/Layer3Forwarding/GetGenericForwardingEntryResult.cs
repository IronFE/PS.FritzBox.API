using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64
{
    /// <summary>
    /// result object for GetGenericForwardingEntry
    /// </summary>
    public class GetGenericForwardingEntryResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetGenericForwardingEntryResult(XDocument soapresult)
        {
            this.Enable = soapresult.Descendants("NewEnable").First().Value == "1";
            this.Status = soapresult.Descendants("NewStatus").First().Value;
            this.Type = soapresult.Descendants("NewType").First().Value;
            this.DestIPAddress = soapresult.Descendants("NewDestIPAddress").First().Value;
            this.DestSubnetMask = soapresult.Descendants("NewDestSubnetMask").First().Value;
            this.SourceIPAddress = soapresult.Descendants("NewSourceIPAddress").First().Value;
            this.SourceSubnetMask = soapresult.Descendants("NewSourceSubnetMask").First().Value;
            this.GatewayIPAddress = soapresult.Descendants("NewGatewayIPAddress").First().Value;
            this.Interface = soapresult.Descendants("NewInterface").First().Value;
            this.ForwardingMetric = Convert.ToInt32(soapresult.Descendants("NewForwardingMetric").First().Value);
        }

        #endregion

        #region properties

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
        /// gets or sets the DestIPAddress
        /// </summary>
        public string DestIPAddress { get; internal set;}

        /// <summary>
        /// gets or sets the DestSubnetMask
        /// </summary>
        public string DestSubnetMask { get; internal set;}

        /// <summary>
        /// gets or sets the SourceIPAddress
        /// </summary>
        public string SourceIPAddress { get; internal set;}

        /// <summary>
        /// gets or sets the SourceSubnetMask
        /// </summary>
        public string SourceSubnetMask { get; internal set;}

        /// <summary>
        /// gets or sets the GatewayIPAddress
        /// </summary>
        public string GatewayIPAddress { get; internal set;}

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