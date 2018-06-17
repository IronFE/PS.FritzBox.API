using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.UserInterface
{
    /// <summary>
    /// result object for X_GetInternationalConfig
    /// </summary>
    public class X_GetInternationalConfigResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetInternationalConfigResult(XDocument soapresult)
        {
            this.Language = soapresult.Descendants("NewX_AVM-DE_Language").First().Value;
            this.Country = soapresult.Descendants("NewX_AVM-DE_Country").First().Value;
            this.Annex = soapresult.Descendants("NewX_AVM-DE_Annex").First().Value;
            this.LanguageList = soapresult.Descendants("NewX_AVM-DE_LanguageList").First().Value;
            this.CountryList = soapresult.Descendants("NewX_AVM-DE_CountryList").First().Value;
            this.AnnexList = soapresult.Descendants("NewX_AVM-DE_AnnexList").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Language
        /// </summary>
        public string Language { get; internal set;}

        /// <summary>
        /// gets or sets the Country
        /// </summary>
        public string Country { get; internal set;}

        /// <summary>
        /// gets or sets the Annex
        /// </summary>
        public string Annex { get; internal set;}

        /// <summary>
        /// gets or sets the LanguageList
        /// </summary>
        public string LanguageList { get; internal set;}

        /// <summary>
        /// gets or sets the CountryList
        /// </summary>
        public string CountryList { get; internal set;}

        /// <summary>
        /// gets or sets the AnnexList
        /// </summary>
        public string AnnexList { get; internal set;}

        #endregion
    }
}