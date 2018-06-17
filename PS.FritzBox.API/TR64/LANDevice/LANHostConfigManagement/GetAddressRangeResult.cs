using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.LANHostConfigManagement
{
    /// <summary>
    /// result object for GetAddressRange
    /// </summary>
    public class GetAddressRangeResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetAddressRangeResult(XDocument soapresult)
        {
            this.MinAddress = soapresult.Descendants("NewMinAddress").First().Value;
            this.MaxAddress = soapresult.Descendants("NewMaxAddress").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the MinAddress
        /// </summary>
        public string MinAddress { get; internal set;}

        /// <summary>
        /// gets or sets the MaxAddress
        /// </summary>
        public string MaxAddress { get; internal set;}

        #endregion
    }
}