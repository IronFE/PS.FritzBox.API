using PS.FritzBox.API.Base;
using PS.FritzBox.API.WANDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice
{
    /// <summary>
    /// client proxy class for WANDSLInterfaceConfig service
    /// </summary>
    public class WANDSLInterfaceConfigService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for WANDSLInterfaceConfigService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public WANDSLInterfaceConfigService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for WANDSLInterfaceConfigService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public WANDSLInterfaceConfigService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for WANDSLInterfaceConfigService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public WANDSLInterfaceConfigService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for WANDSLInterfaceConfigService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public WANDSLInterfaceConfigService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/wandslifconfig1";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:WANDSLInterfaceConfig:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke GetInfo on service
        /// </summary>
        /// <returns>the result of the action GetInfo</returns>
        public async Task<GetWANDLSInterfaceInfoResult> GetWANDLSInterfaceInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetInfo", null);
            return new GetWANDLSInterfaceInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetStatisticsTotal on service
        /// </summary>
        /// <returns>the result of the action GetStatisticsTotal</returns>
        public async Task<GetStatisticsTotalResult> GetStatisticsTotalAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetStatisticsTotal", null);
            return new GetStatisticsTotalResult(soapResult);
        }

        #endregion
    }
}