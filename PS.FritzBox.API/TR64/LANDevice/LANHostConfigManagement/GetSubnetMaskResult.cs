using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.LANHostConfigManagement
{
    /// <summary>
    /// result object for GetSubnetMask
    /// </summary>
    public class GetSubnetMaskResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetSubnetMaskResult(XDocument soapresult)
        {
            this.SubnetMask = soapresult.Descendants("NewSubnetMask").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the SubnetMask
        /// </summary>
        public string SubnetMask { get; internal set;}

        #endregion
    }
}