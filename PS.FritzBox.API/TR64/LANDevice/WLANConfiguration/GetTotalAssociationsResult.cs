using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for GetTotalAssociations
    /// </summary>
    public class GetTotalAssociationsResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetTotalAssociationsResult(XDocument soapresult)
        {
            this.TotalAssociations = Convert.ToInt32(soapresult.Descendants("NewTotalAssociations").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the TotalAssociations
        /// </summary>
        public Int32 TotalAssociations { get; internal set;}

        #endregion
    }
}