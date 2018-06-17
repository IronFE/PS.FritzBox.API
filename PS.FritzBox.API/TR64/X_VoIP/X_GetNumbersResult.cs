using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for X_GetNumbers
    /// </summary>
    public class X_GetNumbersResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetNumbersResult(XDocument soapresult)
        {
            this.NumberList = soapresult.Descendants("NewNumberList").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the NumberList
        /// </summary>
        public string NumberList { get; internal set;}

        #endregion
    }
}