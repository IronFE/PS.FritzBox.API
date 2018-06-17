using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANDSLLinkConfig
{
    /// <summary>
    /// result object for GetATMEncapsulation
    /// </summary>
    public class GetATMEncapsulationResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetATMEncapsulationResult(XDocument soapresult)
        {
            this.ATMEncapsulation = (ATMEncapsulation)Enum.Parse(typeof(ATMEncapsulation), soapresult.Descendants("NewATMEncapsulation").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ATMEncapsulation
        /// </summary>
        public ATMEncapsulation ATMEncapsulation { get; internal set;}

        #endregion
    }
}