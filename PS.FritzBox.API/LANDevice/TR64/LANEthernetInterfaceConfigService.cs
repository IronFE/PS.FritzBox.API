using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.LANDevice.TR64
{
    /// <summary>
    /// client proxy class for LANEthernetInterfaceConfig service
    /// </summary>
    public class LANEthernetInterfaceConfigService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for LANEthernetInterfaceConfigService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public LANEthernetInterfaceConfigService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for LANEthernetInterfaceConfigService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public LANEthernetInterfaceConfigService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for LANEthernetInterfaceConfigService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public LANEthernetInterfaceConfigService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for LANEthernetInterfaceConfigService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public LANEthernetInterfaceConfigService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/lanethernetifcfg";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:LANEthernetInterfaceConfig:1";
		
        #endregion

        #region Methods

        /// <summary>
        /// method to invoke SetEnable on service
        /// </summary>
        /// <param name="request">the request for the action SetEnable</param>
        public async Task SetEnableAsync(SetEnableRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewEnable", request.Enable ? "1" : "0")
            };
            await base.InvokeAsync("SetEnable", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetInfo on service
        /// </summary>
        /// <returns>the result of the action GetInfo</returns>
        public async Task<GetInfoResult> GetInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetInfo", null);
            return new GetInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetStatistics on service
        /// </summary>
        /// <returns>the result of the action GetStatistics</returns>
        public async Task<GetStatisticsResult> GetStatisticsAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetStatistics", null);
            return new GetStatisticsResult(soapResult);
        }

        #endregion
    }
}