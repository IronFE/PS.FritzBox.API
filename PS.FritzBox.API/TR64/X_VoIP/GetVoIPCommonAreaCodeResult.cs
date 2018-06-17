using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for GetVoIPCommonAreaCode
    /// </summary>
    public class GetVoIPCommonAreaCodeResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetVoIPCommonAreaCodeResult(XDocument soapresult)
        {
            this.VoIPAreaCode = soapresult.Descendants("NewVoIPAreaCode").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the VoIPAreaCode
        /// </summary>
        public string VoIPAreaCode { get; internal set;}

        #endregion
    }
}