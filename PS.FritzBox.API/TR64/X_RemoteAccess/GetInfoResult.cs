using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_RemoteAccess
{
    /// <summary>
    /// result object for GetInfo
    /// </summary>
    public class GetInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetInfoResult(XDocument soapresult)
        {
            this.Enabled = soapresult.Descendants("NewEnabled").First().Value == "1";
            this.Port = soapresult.Descendants("NewPort").First().Value;
            this.Username = soapresult.Descendants("NewUsername").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enabled
        /// </summary>
        public bool Enabled { get; internal set;}

        /// <summary>
        /// gets or sets the Port
        /// </summary>
        public string Port { get; internal set;}

        /// <summary>
        /// gets or sets the Username
        /// </summary>
        public string Username { get; internal set;}

        #endregion
    }
}