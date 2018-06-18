using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
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
            string modulationType = soapresult.Descendants("NewModulationType").First().Value;
            if (modulationType == "ADSL G.LITE")
                modulationType = "ADSL_G_LITE";
            else if (modulationType == "G.SHDSL")
                modulationType = "G_SHDSL";

            this.ModulationType = (ModulationType)Enum.Parse(typeof(ModulationType), modulationType, true);
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