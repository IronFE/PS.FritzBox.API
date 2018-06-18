using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// client proxy class for WANEthernetLinkConfig service
    /// </summary>
    public class WANEthernetLinkConfigService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for WANEthernetLinkConfigService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public WANEthernetLinkConfigService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for WANEthernetLinkConfigService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public WANEthernetLinkConfigService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for WANEthernetLinkConfigService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public WANEthernetLinkConfigService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for WANEthernetLinkConfigService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public WANEthernetLinkConfigService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/wanethlinkconfig1";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:WANEthernetLinkConfig:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke GetEthernetLinkStatus on service
        /// </summary>
        /// <returns>the result of the action GetEthernetLinkStatus</returns>
        public async Task<GetEthernetLinkStatusResult> GetEthernetLinkStatusAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetEthernetLinkStatus", null);
            return new GetEthernetLinkStatusResult(soapResult);
        }

        #endregion
    }
}