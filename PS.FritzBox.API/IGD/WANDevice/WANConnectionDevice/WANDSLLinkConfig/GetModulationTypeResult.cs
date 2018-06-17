using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANDSLLinkConfig
{
    /// <summary>
    /// result object for GetModulationType
    /// </summary>
    public class GetModulationTypeResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetModulationTypeResult(XDocument soapresult)
        {
            this.ModulationType = (ModulationType)Enum.Parse(typeof(ModulationType), soapresult.Descendants("NewModulationType").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ModulationType
        /// </summary>
        public ModulationType ModulationType { get; internal set;}

        #endregion
    }
}