using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANIPConnection
{
    /// <summary>
    /// result object for GetAutoDisconnectTime
    /// </summary>
    public class GetAutoDisconnectTimeResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetAutoDisconnectTimeResult(XDocument soapresult)
        {
            this.AutoDisconnectTime = Convert.ToInt32(soapresult.Descendants("NewAutoDisconnectTime").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the AutoDisconnectTime
        /// </summary>
        public Int32 AutoDisconnectTime { get; internal set;}

        #endregion
    }
}