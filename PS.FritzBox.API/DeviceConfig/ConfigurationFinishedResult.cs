using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64
{
    /// <summary>
    /// result object for ConfigurationFinished
    /// </summary>
    public class ConfigurationFinishedResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal ConfigurationFinishedResult(XDocument soapresult)
        {
            this.Status = soapresult.Descendants("NewStatus").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Status
        /// </summary>
        public string Status { get; internal set;}

        #endregion
    }
}