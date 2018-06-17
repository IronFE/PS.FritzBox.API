using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// result object for GetDECTHandsetInfo
    /// </summary>
    public class GetDECTHandsetInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetDECTHandsetInfoResult(XDocument soapresult)
        {
            this.HandsetName = soapresult.Descendants("NewHandsetName").First().Value;
            this.PhonebookID = Convert.ToInt32(soapresult.Descendants("NewPhonebookID").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the HandsetName
        /// </summary>
        public string HandsetName { get; internal set;}

        /// <summary>
        /// gets or sets the PhonebookID
        /// </summary>
        public Int32 PhonebookID { get; internal set;}

        #endregion
    }
}