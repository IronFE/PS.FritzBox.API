using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Filelinks
{
    /// <summary>
    /// result object for NewFilelinkEntry
    /// </summary>
    public class NewFilelinkEntryResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal NewFilelinkEntryResult(XDocument soapresult)
        {
            this.ID = soapresult.Descendants("NewID").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ID
        /// </summary>
        public string ID { get; internal set;}

        #endregion
    }
}