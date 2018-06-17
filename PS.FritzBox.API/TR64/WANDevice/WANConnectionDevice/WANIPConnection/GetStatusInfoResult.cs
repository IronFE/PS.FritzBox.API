using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANIPConnection
{
    /// <summary>
    /// result object for GetStatusInfo
    /// </summary>
    public class GetStatusInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetStatusInfoResult(XDocument soapresult)
        {
            this.ConnectionStatus = (ConnectionStatus)Enum.Parse(typeof(ConnectionStatus), soapresult.Descendants("NewConnectionStatus").First().Value);
            this.LastConnectionError = (LastConnectionError)Enum.Parse(typeof(LastConnectionError), soapresult.Descendants("NewLastConnectionError").First().Value);
            this.Uptime = Convert.ToInt32(soapresult.Descendants("NewUptime").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ConnectionStatus
        /// </summary>
        public ConnectionStatus ConnectionStatus { get; internal set;}

        /// <summary>
        /// gets or sets the LastConnectionError
        /// </summary>
        public LastConnectionError LastConnectionError { get; internal set;}

        /// <summary>
        /// gets or sets the Uptime
        /// </summary>
        public Int32 Uptime { get; internal set;}

        #endregion
    }
}