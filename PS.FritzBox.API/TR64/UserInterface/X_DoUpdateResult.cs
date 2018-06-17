using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.UserInterface
{
    /// <summary>
    /// result object for X_DoUpdate
    /// </summary>
    public class X_DoUpdateResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_DoUpdateResult(XDocument soapresult)
        {
            this.UpgradeAvailable = soapresult.Descendants("NewUpgradeAvailable").First().Value == "1";
            this.UpdateState = (UpdateState)Enum.Parse(typeof(UpdateState), soapresult.Descendants("NewX_AVM-DE_UpdateState").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the UpgradeAvailable
        /// </summary>
        public bool UpgradeAvailable { get; internal set;}

        /// <summary>
        /// gets or sets the UpdateState
        /// </summary>
        public UpdateState UpdateState { get; internal set;}

        #endregion
    }
}