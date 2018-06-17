using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.DeviceInfo
{
    /// <summary>
    /// result object for GetDeviceLog
    /// </summary>
    public class GetDeviceLogResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetDeviceLogResult(XDocument soapresult)
        {
            this.DeviceLog = soapresult.Descendants("NewDeviceLog").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the DeviceLog
        /// </summary>
        public string DeviceLog { get; internal set;}

        #endregion
    }
}