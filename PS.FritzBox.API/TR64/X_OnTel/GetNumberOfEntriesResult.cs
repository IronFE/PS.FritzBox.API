using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// result object for GetNumberOfEntries
    /// </summary>
    public class GetNumberOfEntriesResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetNumberOfEntriesResult(XDocument soapresult)
        {
            this.OnTelNumberOfEntries = Convert.ToInt32(soapresult.Descendants("NewOnTelNumberOfEntries").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the OnTelNumberOfEntries
        /// </summary>
        public Int32 OnTelNumberOfEntries { get; internal set;}

        #endregion
    }
}