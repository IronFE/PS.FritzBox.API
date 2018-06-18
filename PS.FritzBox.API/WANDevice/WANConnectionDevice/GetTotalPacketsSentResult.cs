using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice
{
    /// <summary>
    /// result object for GetTotalPacketsSent
    /// </summary>
    public class GetTotalPacketsSentResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetTotalPacketsSentResult(XDocument soapresult)
        {
            this.TotalPacketsSent = Convert.ToInt32(soapresult.Descendants("NewTotalPacketsSent").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the TotalPacketsSent
        /// </summary>
        public Int32 TotalPacketsSent { get; internal set;}

        #endregion
    }
}