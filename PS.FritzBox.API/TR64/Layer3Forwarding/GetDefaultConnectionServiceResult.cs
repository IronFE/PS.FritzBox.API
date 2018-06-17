using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.Layer3Forwarding
{
    /// <summary>
    /// result object for GetDefaultConnectionService
    /// </summary>
    public class GetDefaultConnectionServiceResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetDefaultConnectionServiceResult(XDocument soapresult)
        {
            this.DefaultConnectionService = soapresult.Descendants("NewDefaultConnectionService").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the DefaultConnectionService
        /// </summary>
        public string DefaultConnectionService { get; internal set;}

        #endregion
    }
}