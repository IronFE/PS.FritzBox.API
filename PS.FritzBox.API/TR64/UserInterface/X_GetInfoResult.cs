using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.UserInterface
{
    /// <summary>
    /// result object for X_GetInfo
    /// </summary>
    public class X_GetInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetInfoResult(XDocument soapresult)
        {
            this.AutoUpdateMode = (AutoUpdateMode)Enum.Parse(typeof(AutoUpdateMode), soapresult.Descendants("NewX_AVM-DE_AutoUpdateMode").First().Value);
            this.UpdateTime = Convert.ToDateTime(soapresult.Descendants("NewX_AVM-DE_UpdateTime").First().Value);
            this.LastFwVersion = soapresult.Descendants("NewX_AVM-DE_LastFwVersion").First().Value;
            this.LastInfoUrl = soapresult.Descendants("NewX_AVM-DE_LastInfoUrl").First().Value;
            this.CurrentFwVersion = soapresult.Descendants("NewX_AVM-DE_CurrentFwVersion").First().Value;
            this.UpdateSuccessful = (UpdateSuccessful)Enum.Parse(typeof(UpdateSuccessful), soapresult.Descendants("NewX_AVM-DE_UpdateSuccessful").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the AutoUpdateMode
        /// </summary>
        public AutoUpdateMode AutoUpdateMode { get; internal set;}

        /// <summary>
        /// gets or sets the UpdateTime
        /// </summary>
        public DateTime UpdateTime { get; internal set;}

        /// <summary>
        /// gets or sets the LastFwVersion
        /// </summary>
        public string LastFwVersion { get; internal set;}

        /// <summary>
        /// gets or sets the LastInfoUrl
        /// </summary>
        public string LastInfoUrl { get; internal set;}

        /// <summary>
        /// gets or sets the CurrentFwVersion
        /// </summary>
        public string CurrentFwVersion { get; internal set;}

        /// <summary>
        /// gets or sets the UpdateSuccessful
        /// </summary>
        public UpdateSuccessful UpdateSuccessful { get; internal set;}

        #endregion
    }
}