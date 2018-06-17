using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.LANHostConfigManagement
{
    /// <summary>
    /// result object for GetIPInterfaceNumberOfEntries
    /// </summary>
    public class GetIPInterfaceNumberOfEntriesResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetIPInterfaceNumberOfEntriesResult(XDocument soapresult)
        {
            this.IPInterfaceNumberOfEntries = Convert.ToInt32(soapresult.Descendants("NewIPInterfaceNumberOfEntries").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the IPInterfaceNumberOfEntries
        /// </summary>
        public Int32 IPInterfaceNumberOfEntries { get; internal set;}

        #endregion
    }
}