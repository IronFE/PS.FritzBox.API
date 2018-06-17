using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.LANHostConfigManagement
{
    /// <summary>
    /// result object for GetIPRoutersList
    /// </summary>
    public class GetIPRoutersListResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetIPRoutersListResult(XDocument soapresult)
        {
            this.IPRouters = soapresult.Descendants("NewIPRouters").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the IPRouters
        /// </summary>
        public string IPRouters { get; internal set;}

        #endregion
    }
}