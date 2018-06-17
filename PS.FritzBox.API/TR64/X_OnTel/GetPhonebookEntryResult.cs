using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// result object for GetPhonebookEntry
    /// </summary>
    public class GetPhonebookEntryResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetPhonebookEntryResult(XDocument soapresult)
        {
            this.PhonebookEntryData = soapresult.Descendants("NewPhonebookEntryData").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the PhonebookEntryData
        /// </summary>
        public string PhonebookEntryData { get; internal set;}

        #endregion
    }
}