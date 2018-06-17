using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_TAM
{
    /// <summary>
    /// result object for GetMessageList
    /// </summary>
    public class GetMessageListResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetMessageListResult(XDocument soapresult)
        {
            this.URL = soapresult.Descendants("NewURL").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the URL
        /// </summary>
        public string URL { get; internal set;}

        #endregion
    }
}