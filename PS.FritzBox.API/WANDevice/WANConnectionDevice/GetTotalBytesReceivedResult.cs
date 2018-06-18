using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice
{
    /// <summary>
    /// result object for GetTotalBytesReceived
    /// </summary>
    public class GetTotalBytesReceivedResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetTotalBytesReceivedResult(XDocument soapresult)
        {
            this.TotalBytesReceived = Convert.ToInt32(soapresult.Descendants("NewTotalBytesReceived").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the TotalBytesReceived
        /// </summary>
        public Int32 TotalBytesReceived { get; internal set;}

        #endregion
    }
}