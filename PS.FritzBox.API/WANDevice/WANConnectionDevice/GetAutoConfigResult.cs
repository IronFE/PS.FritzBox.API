using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for GetAutoConfig
    /// </summary>
    public class GetAutoConfigResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetAutoConfigResult(XDocument soapresult)
        {
            this.AutoConfig = soapresult.Descendants("NewAutoConfig").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the AutoConfig
        /// </summary>
        public bool AutoConfig { get; internal set;}

        #endregion
    }
}