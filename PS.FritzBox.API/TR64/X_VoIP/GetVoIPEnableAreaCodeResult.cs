using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for GetVoIPEnableAreaCode
    /// </summary>
    public class GetVoIPEnableAreaCodeResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetVoIPEnableAreaCodeResult(XDocument soapresult)
        {
            this.VoIPEnableAreaCode = soapresult.Descendants("NewVoIPEnableAreaCode").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the VoIPEnableAreaCode
        /// </summary>
        public bool VoIPEnableAreaCode { get; internal set;}

        #endregion
    }
}