using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// result object for GetCallList
    /// </summary>
    public class GetCallListResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetCallListResult(XDocument soapresult)
        {
            this.CallListURL = soapresult.Descendants("NewCallListURL").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the CallListURL
        /// </summary>
        public string CallListURL { get; internal set;}

        #endregion
    }
}