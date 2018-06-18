using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for GetDestinationAddress
    /// </summary>
    public class GetDestinationAddressResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetDestinationAddressResult(XDocument soapresult)
        {
            this.DestinationAddress = soapresult.Descendants("NewDestinationAddress").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the DestinationAddress
        /// </summary>
        public string DestinationAddress { get; internal set;}

        #endregion
    }
}