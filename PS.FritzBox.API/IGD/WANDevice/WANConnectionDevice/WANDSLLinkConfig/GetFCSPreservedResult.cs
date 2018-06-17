using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANDSLLinkConfig
{
    /// <summary>
    /// result object for GetFCSPreserved
    /// </summary>
    public class GetFCSPreservedResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetFCSPreservedResult(XDocument soapresult)
        {
            this.FCSPreserved = soapresult.Descendants("NewFCSPreserved").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the FCSPreserved
        /// </summary>
        public bool FCSPreserved { get; internal set;}

        #endregion
    }
}