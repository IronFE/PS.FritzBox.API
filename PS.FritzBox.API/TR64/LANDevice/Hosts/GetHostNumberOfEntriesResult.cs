using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.Hosts
{
    /// <summary>
    /// result object for GetHostNumberOfEntries
    /// </summary>
    public class GetHostNumberOfEntriesResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetHostNumberOfEntriesResult(XDocument soapresult)
        {
            this.HostNumberOfEntries = Convert.ToInt32(soapresult.Descendants("NewHostNumberOfEntries").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the HostNumberOfEntries
        /// </summary>
        public Int32 HostNumberOfEntries { get; internal set;}

        #endregion
    }
}