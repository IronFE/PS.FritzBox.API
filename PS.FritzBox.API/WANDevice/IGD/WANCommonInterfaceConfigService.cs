using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.IGD
{
    /// <summary>
    /// client proxy class for WANCommonInterfaceConfig service
    /// </summary>
    public class WANCommonInterfaceConfigService : FritzServiceBase, IWANCommonInterfaceConfigService
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for WANCommonInterfaceConfigService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public WANCommonInterfaceConfigService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for WANCommonInterfaceConfigService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public WANCommonInterfaceConfigService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for WANCommonInterfaceConfigService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public WANCommonInterfaceConfigService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for WANCommonInterfaceConfigService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public WANCommonInterfaceConfigService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/igdupnp/control/WANCommonIFC1";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:schemas-upnp-org:service:WANCommonInterfaceConfig:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke GetCommonLinkProperties on service
        /// </summary>
        /// <returns>the result of the action GetCommonLinkProperties</returns>
        public async Task<GetCommonLinkPropertiesResult> GetCommonLinkPropertiesAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetCommonLinkProperties", null);
            return new GetCommonLinkPropertiesResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetTotalBytesSent on service
        /// </summary>
        /// <returns>the result of the action GetTotalBytesSent</returns>
        public async Task<GetTotalBytesSentResult> GetTotalBytesSentAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetTotalBytesSent", null);
            return new GetTotalBytesSentResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetTotalBytesReceived on service
        /// </summary>
        /// <returns>the result of the action GetTotalBytesReceived</returns>
        public async Task<GetTotalBytesReceivedResult> GetTotalBytesReceivedAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetTotalBytesReceived", null);
            return new GetTotalBytesReceivedResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetTotalPacketsSent on service
        /// </summary>
        /// <returns>the result of the action GetTotalPacketsSent</returns>
        public async Task<GetTotalPacketsSentResult> GetTotalPacketsSentAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetTotalPacketsSent", null);
            return new GetTotalPacketsSentResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetTotalPacketsReceived on service
        /// </summary>
        /// <returns>the result of the action GetTotalPacketsReceived</returns>
        public async Task<GetTotalPacketsReceivedResult> GetTotalPacketsReceivedAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetTotalPacketsReceived", null);
            return new GetTotalPacketsReceivedResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetAddonInfos on service
        /// </summary>
        /// <returns>the result of the action GetAddonInfos</returns>
        public async Task<GetAddonInfosResult> GetAddonInfosAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetAddonInfos", null);
            return new GetAddonInfosResult(soapResult);
        }

        #endregion
    }
}