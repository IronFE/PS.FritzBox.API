using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for X_GetWLANExtInfo
    /// </summary>
    public class X_GetWLANExtInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetWLANExtInfoResult(XDocument soapresult)
        {
            this.APEnabled = soapresult.Descendants("NewX_AVM-DE_APEnabled").First().Value;
            this.APType = soapresult.Descendants("NewX_AVM-DE_APType").First().Value;
            this.TimeoutActive = soapresult.Descendants("NewX_AVM-DE_TimeoutActive").First().Value;
            this.Timeout = soapresult.Descendants("NewX_AVM-DE_Timeout").First().Value;
            this.TimeRemain = soapresult.Descendants("NewX_AVM-DE_TimeRemain").First().Value;
            this.NoForcedOff = soapresult.Descendants("NewX_AVM-DE_NoForcedOff").First().Value;
            this.UserIsolation = soapresult.Descendants("NewX_AVM-DE_UserIsolation").First().Value;
            this.EncryptionMode = soapresult.Descendants("NewX_AVM-DE_EncryptionMode").First().Value;
            this.LastChangedStamp = Convert.ToInt32(soapresult.Descendants("NewX_AVM-DE_LastChangedStamp").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the APEnabled
        /// </summary>
        public string APEnabled { get; internal set;}

        /// <summary>
        /// gets or sets the APType
        /// </summary>
        public string APType { get; internal set;}

        /// <summary>
        /// gets or sets the TimeoutActive
        /// </summary>
        public string TimeoutActive { get; internal set;}

        /// <summary>
        /// gets or sets the Timeout
        /// </summary>
        public string Timeout { get; internal set;}

        /// <summary>
        /// gets or sets the TimeRemain
        /// </summary>
        public string TimeRemain { get; internal set;}

        /// <summary>
        /// gets or sets the NoForcedOff
        /// </summary>
        public string NoForcedOff { get; internal set;}

        /// <summary>
        /// gets or sets the UserIsolation
        /// </summary>
        public string UserIsolation { get; internal set;}

        /// <summary>
        /// gets or sets the EncryptionMode
        /// </summary>
        public string EncryptionMode { get; internal set;}

        /// <summary>
        /// gets or sets the LastChangedStamp
        /// </summary>
        public Int32 LastChangedStamp { get; internal set;}

        #endregion
    }
}