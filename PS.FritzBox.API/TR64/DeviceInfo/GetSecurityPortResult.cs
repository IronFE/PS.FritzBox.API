using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.DeviceInfo
{
    /// <summary>
    /// result object for GetSecurityPort
    /// </summary>
    public class GetSecurityPortResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetSecurityPortResult(XDocument soapresult)
        {
            this.SecurityPort = Convert.ToInt32(soapresult.Descendants("NewSecurityPort").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the SecurityPort
        /// </summary>
        public Int32 SecurityPort { get; internal set;}

        #endregion
    }
}