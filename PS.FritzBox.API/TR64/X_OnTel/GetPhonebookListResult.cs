using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// result object for GetPhonebookList
    /// </summary>
    public class GetPhonebookListResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetPhonebookListResult(XDocument soapresult)
        {
            this.PhonebookList = soapresult.Descendants("NewPhonebookList").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the PhonebookList
        /// </summary>
        public string PhonebookList { get; internal set;}

        #endregion
    }
}