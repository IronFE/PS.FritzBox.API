using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// result object for GetPhonebook
    /// </summary>
    public class GetPhonebookResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetPhonebookResult(XDocument soapresult)
        {
            this.PhonebookName = soapresult.Descendants("NewPhonebookName").First().Value;
            this.PhonebookExtraID = soapresult.Descendants("NewPhonebookExtraID").First().Value;
            this.PhonebookURL = soapresult.Descendants("NewPhonebookURL").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the PhonebookName
        /// </summary>
        public string PhonebookName { get; internal set;}

        /// <summary>
        /// gets or sets the PhonebookExtraID
        /// </summary>
        public string PhonebookExtraID { get; internal set;}

        /// <summary>
        /// gets or sets the PhonebookURL
        /// </summary>
        public string PhonebookURL { get; internal set;}

        #endregion
    }
}