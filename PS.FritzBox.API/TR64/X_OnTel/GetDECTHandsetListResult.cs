using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// result object for GetDECTHandsetList
    /// </summary>
    public class GetDECTHandsetListResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetDECTHandsetListResult(XDocument soapresult)
        {
            this.DectIDList = soapresult.Descendants("NewDectIDList").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the DectIDList
        /// </summary>
        public string DectIDList { get; internal set;}

        #endregion
    }
}