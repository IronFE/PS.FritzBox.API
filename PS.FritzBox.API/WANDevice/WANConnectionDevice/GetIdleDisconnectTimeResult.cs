using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for GetIdleDisconnectTime
    /// </summary>
    public class GetIdleDisconnectTimeResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetIdleDisconnectTimeResult(XDocument soapresult)
        {
            this.IdleDisconnectTime = Convert.ToInt32(soapresult.Descendants("NewIdleDisconnectTime").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the IdleDisconnectTime
        /// </summary>
        public Int32 IdleDisconnectTime { get; internal set;}

        #endregion
    }
}