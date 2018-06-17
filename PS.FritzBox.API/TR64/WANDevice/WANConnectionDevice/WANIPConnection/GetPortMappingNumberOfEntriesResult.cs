using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANIPConnection
{
    /// <summary>
    /// result object for GetPortMappingNumberOfEntries
    /// </summary>
    public class GetPortMappingNumberOfEntriesResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetPortMappingNumberOfEntriesResult(XDocument soapresult)
        {
            this.PortMappingNumberOfEntries = Convert.ToInt32(soapresult.Descendants("NewPortMappingNumberOfEntries").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the PortMappingNumberOfEntries
        /// </summary>
        public Int32 PortMappingNumberOfEntries { get; internal set;}

        #endregion
    }
}