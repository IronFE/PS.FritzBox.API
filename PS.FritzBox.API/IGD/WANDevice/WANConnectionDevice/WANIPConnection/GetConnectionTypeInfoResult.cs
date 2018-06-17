using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANIPConnection
{
    /// <summary>
    /// result object for GetConnectionTypeInfo
    /// </summary>
    public class GetConnectionTypeInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetConnectionTypeInfoResult(XDocument soapresult)
        {
            this.ConnectionType = soapresult.Descendants("NewConnectionType").First().Value;
            this.PossibleConnectionTypes = (PossibleConnectionTypes)Enum.Parse(typeof(PossibleConnectionTypes), soapresult.Descendants("NewPossibleConnectionTypes").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ConnectionType
        /// </summary>
        public string ConnectionType { get; internal set;}

        /// <summary>
        /// gets or sets the PossibleConnectionTypes
        /// </summary>
        public PossibleConnectionTypes PossibleConnectionTypes { get; internal set;}

        #endregion
    }
}