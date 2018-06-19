using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64
{
    /// <summary>
    /// result object for GetForwardNumberOfEntries
    /// </summary>
    public class GetForwardNumberOfEntriesResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetForwardNumberOfEntriesResult(XDocument soapresult)
        {
            this.ForwardNumberOfEntries = Convert.ToInt32(soapresult.Descendants("NewForwardNumberOfEntries").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ForwardNumberOfEntries
        /// </summary>
        public Int32 ForwardNumberOfEntries { get; internal set;}

        #endregion
    }
}