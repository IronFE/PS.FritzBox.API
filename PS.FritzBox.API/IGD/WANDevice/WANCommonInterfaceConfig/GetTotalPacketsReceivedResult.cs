using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANCommonInterfaceConfig
{
    /// <summary>
    /// result object for GetTotalPacketsReceived
    /// </summary>
    public class GetTotalPacketsReceivedResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetTotalPacketsReceivedResult(XDocument soapresult)
        {
            this.TotalPacketsReceived = Convert.ToInt32(soapresult.Descendants("NewTotalPacketsReceived").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the TotalPacketsReceived
        /// </summary>
        public Int32 TotalPacketsReceived { get; internal set;}

        #endregion
    }
}