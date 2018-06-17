using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.ManagementServer
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
            this.URL = soapresult.Descendants("NewURL").First().Value;
            this.Username = soapresult.Descendants("NewUsername").First().Value;
            this.PeriodicInformEnable = soapresult.Descendants("NewPeriodicInformEnable").First().Value == "1";
            this.PeriodicInformInterval = Convert.ToInt32(soapresult.Descendants("NewPeriodicInformInterval").First().Value);
            this.PeriodicInformTime = Convert.ToDateTime(soapresult.Descendants("NewPeriodicInformTime").First().Value);
            this.ParameterKey = soapresult.Descendants("NewParameterKey").First().Value;
            this.ParameterHash = soapresult.Descendants("NewParameterHash").First().Value;
            this.ConnectionRequestURL = soapresult.Descendants("NewConnectionRequestURL").First().Value;
            this.ConnectionRequestUsername = soapresult.Descendants("NewConnectionRequestUsername").First().Value;
            this.UpgradesManaged = soapresult.Descendants("NewUpgradesManaged").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the URL
        /// </summary>
        public string URL { get; internal set;}

        /// <summary>
        /// gets or sets the Username
        /// </summary>
        public string Username { get; internal set;}

        /// <summary>
        /// gets or sets the PeriodicInformEnable
        /// </summary>
        public bool PeriodicInformEnable { get; internal set;}

        /// <summary>
        /// gets or sets the PeriodicInformInterval
        /// </summary>
        public Int32 PeriodicInformInterval { get; internal set;}

        /// <summary>
        /// gets or sets the PeriodicInformTime
        /// </summary>
        public DateTime PeriodicInformTime { get; internal set;}

        /// <summary>
        /// gets or sets the ParameterKey
        /// </summary>
        public string ParameterKey { get; internal set;}

        /// <summary>
        /// gets or sets the ParameterHash
        /// </summary>
        public string ParameterHash { get; internal set;}

        /// <summary>
        /// gets or sets the ConnectionRequestURL
        /// </summary>
        public string ConnectionRequestURL { get; internal set;}

        /// <summary>
        /// gets or sets the ConnectionRequestUsername
        /// </summary>
        public string ConnectionRequestUsername { get; internal set;}

        /// <summary>
        /// gets or sets the UpgradesManaged
        /// </summary>
        public bool UpgradesManaged { get; internal set;}

        #endregion
    }
}