using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANIPv6FirewallControl
{
    /// <summary>
    /// result object for CheckPinholeWorking
    /// </summary>
    public class CheckPinholeWorkingResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal CheckPinholeWorkingResult(XDocument soapresult)
        {
            this.IsWorking = soapresult.Descendants("IsWorking").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the IsWorking
        /// </summary>
        public bool IsWorking { get; internal set;}

        #endregion
    }
}