using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANCommonInterfaceConfig
{
    /// <summary>
    /// result object for GetTotalBytesSent
    /// </summary>
    public class GetTotalBytesSentResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetTotalBytesSentResult(XDocument soapresult)
        {
            this.TotalBytesSent = Convert.ToInt32(soapresult.Descendants("NewTotalBytesSent").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the TotalBytesSent
        /// </summary>
        public Int32 TotalBytesSent { get; internal set;}

        #endregion
    }
}