using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// result object for GetNumberOfDeflections
    /// </summary>
    public class GetNumberOfDeflectionsResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetNumberOfDeflectionsResult(XDocument soapresult)
        {
            this.NumberOfDeflections = Convert.ToInt32(soapresult.Descendants("NewNumberOfDeflections").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the NumberOfDeflections
        /// </summary>
        public Int32 NumberOfDeflections { get; internal set;}

        #endregion
    }
}