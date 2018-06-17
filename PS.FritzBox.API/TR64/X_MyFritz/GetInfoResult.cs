using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_MyFritz
{
    /// <summary>
    /// result object for GetInfo
    /// </summary>
    public class GetInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetInfoResult(XDocument soapresult)
        {
            this.Enabled = soapresult.Descendants("NewEnabled").First().Value == "1";
            this.DeviceRegistered = soapresult.Descendants("NewDeviceRegistered").First().Value == "1";
            this.DynDNSName = soapresult.Descendants("NewDynDNSName").First().Value;
            this.Port = Convert.ToInt32(soapresult.Descendants("NewPort").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enabled
        /// </summary>
        public bool Enabled { get; internal set;}

        /// <summary>
        /// gets or sets the DeviceRegistered
        /// </summary>
        public bool DeviceRegistered { get; internal set;}

        /// <summary>
        /// gets or sets the DynDNSName
        /// </summary>
        public string DynDNSName { get; internal set;}

        /// <summary>
        /// gets or sets the Port
        /// </summary>
        public Int32 Port { get; internal set;}

        #endregion
    }
}