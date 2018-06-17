using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Dect
{
    /// <summary>
    /// result object for GetNumberOfDectEntries
    /// </summary>
    public class GetNumberOfDectEntriesResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetNumberOfDectEntriesResult(XDocument soapresult)
        {
            this.NumberOfEntries = Convert.ToInt32(soapresult.Descendants("NewNumberOfEntries").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the NumberOfEntries
        /// </summary>
        public Int32 NumberOfEntries { get; internal set;}

        #endregion
    }
}