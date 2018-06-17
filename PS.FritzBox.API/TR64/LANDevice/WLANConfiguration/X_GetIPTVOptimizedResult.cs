using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for X_GetIPTVOptimized
    /// </summary>
    public class X_GetIPTVOptimizedResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetIPTVOptimizedResult(XDocument soapresult)
        {
            this.IPTVoptimize = soapresult.Descendants("NewX_AVM-DE_IPTVoptimize").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the IPTVoptimize
        /// </summary>
        public bool IPTVoptimize { get; internal set;}

        #endregion
    }
}