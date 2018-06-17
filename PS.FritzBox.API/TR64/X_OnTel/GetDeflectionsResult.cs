using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// result object for GetDeflections
    /// </summary>
    public class GetDeflectionsResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetDeflectionsResult(XDocument soapresult)
        {
            this.DeflectionList = soapresult.Descendants("NewDeflectionList").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the DeflectionList
        /// </summary>
        public string DeflectionList { get; internal set;}

        #endregion
    }
}