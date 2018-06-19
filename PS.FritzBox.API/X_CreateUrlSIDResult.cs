using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API
{
    /// <summary>
    /// result object for X_CreateUrlSID
    /// </summary>
    public class X_CreateUrlSIDResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_CreateUrlSIDResult(XDocument soapresult)
        {
            this.UrlSID = soapresult.Descendants("NewX_AVM-DE_UrlSID").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the UrlSID
        /// </summary>
        public string UrlSID { get; internal set;}

        #endregion
    }
}