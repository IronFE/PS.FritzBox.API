using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_RemoteAccess
{
    /// <summary>
    /// result object for GetDDNSInfo
    /// </summary>
    public class GetDDNSInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetDDNSInfoResult(XDocument soapresult)
        {
            this.Enabled = soapresult.Descendants("NewEnabled").First().Value == "1";
            this.ProviderName = soapresult.Descendants("NewProviderName").First().Value;
            this.UpdateURL = soapresult.Descendants("NewUpdateURL").First().Value;
            this.Domain = soapresult.Descendants("NewDomain").First().Value;
            this.StatusIPv4 = soapresult.Descendants("NewStatusIPv4").First().Value;
            this.StatusIPv6 = soapresult.Descendants("NewStatusIPv6").First().Value;
            this.Username = soapresult.Descendants("NewUsername").First().Value;
            this.Mode = (Mode)Enum.Parse(typeof(Mode), soapresult.Descendants("NewMode").First().Value);
            this.ServerIPv4 = soapresult.Descendants("NewServerIPv4").First().Value;
            this.ServerIPv6 = soapresult.Descendants("NewServerIPv6").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enabled
        /// </summary>
        public bool Enabled { get; internal set;}

        /// <summary>
        /// gets or sets the ProviderName
        /// </summary>
        public string ProviderName { get; internal set;}

        /// <summary>
        /// gets or sets the UpdateURL
        /// </summary>
        public string UpdateURL { get; internal set;}

        /// <summary>
        /// gets or sets the Domain
        /// </summary>
        public string Domain { get; internal set;}

        /// <summary>
        /// gets or sets the StatusIPv4
        /// </summary>
        public string StatusIPv4 { get; internal set;}

        /// <summary>
        /// gets or sets the StatusIPv6
        /// </summary>
        public string StatusIPv6 { get; internal set;}

        /// <summary>
        /// gets or sets the Username
        /// </summary>
        public string Username { get; internal set;}

        /// <summary>
        /// gets or sets the Mode
        /// </summary>
        public Mode Mode { get; internal set;}

        /// <summary>
        /// gets or sets the ServerIPv4
        /// </summary>
        public string ServerIPv4 { get; internal set;}

        /// <summary>
        /// gets or sets the ServerIPv6
        /// </summary>
        public string ServerIPv6 { get; internal set;}

        #endregion
    }
}