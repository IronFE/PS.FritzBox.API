using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.UserInterface
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
            this.UpgradeAvailable = soapresult.Descendants("NewUpgradeAvailable").First().Value == "1";
            this.PasswordRequired = soapresult.Descendants("NewPasswordRequired").First().Value == "1";
            this.PasswordUserSelectable = soapresult.Descendants("NewPasswordUserSelectable").First().Value == "1";
            this.WarrantyDate = Convert.ToDateTime(soapresult.Descendants("NewWarrantyDate").First().Value);
            this.Version = soapresult.Descendants("NewX_AVM-DE_Version").First().Value;
            this.DownloadURL = soapresult.Descendants("NewX_AVM-DE_DownloadURL").First().Value;
            this.InfoURL = soapresult.Descendants("NewX_AVM-DE_InfoURL").First().Value;
            this.UpdateState = (UpdateState)Enum.Parse(typeof(UpdateState), soapresult.Descendants("NewX_AVM-DE_UpdateState").First().Value);
            this.LaborVersion = soapresult.Descendants("NewX_AVM-DE_LaborVersion").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the UpgradeAvailable
        /// </summary>
        public bool UpgradeAvailable { get; internal set;}

        /// <summary>
        /// gets or sets the PasswordRequired
        /// </summary>
        public bool PasswordRequired { get; internal set;}

        /// <summary>
        /// gets or sets the PasswordUserSelectable
        /// </summary>
        public bool PasswordUserSelectable { get; internal set;}

        /// <summary>
        /// gets or sets the WarrantyDate
        /// </summary>
        public DateTime WarrantyDate { get; internal set;}

        /// <summary>
        /// gets or sets the Version
        /// </summary>
        public string Version { get; internal set;}

        /// <summary>
        /// gets or sets the DownloadURL
        /// </summary>
        public string DownloadURL { get; internal set;}

        /// <summary>
        /// gets or sets the InfoURL
        /// </summary>
        public string InfoURL { get; internal set;}

        /// <summary>
        /// gets or sets the UpdateState
        /// </summary>
        public UpdateState UpdateState { get; internal set;}

        /// <summary>
        /// gets or sets the LaborVersion
        /// </summary>
        public string LaborVersion { get; internal set;}

        #endregion
    }
}