using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice.TR64
{
    /// <summary>
    /// client proxy class for WANDSLLinkConfig service
    /// </summary>
    public class WANDSLLinkConfigService : FritzServiceBase, IWANDSLLinkConfigService
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for WANDSLLinkConfigService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public WANDSLLinkConfigService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for WANDSLLinkConfigService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public WANDSLLinkConfigService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for WANDSLLinkConfigService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public WANDSLLinkConfigService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for WANDSLLinkConfigService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public WANDSLLinkConfigService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/wandsllinkconfig1";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:WANDSLLinkConfig:1";

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
        public async Task<GetWANDSLLinkConfigInfoResult> GetWANDSLLinkConfigInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetInfo", null);
            return new GetWANDSLLinkConfigInfoResult(soapResult);
        }

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
        /// method to invoke GetAutoConfig on service
        /// </summary>
        /// <returns>the result of the action GetAutoConfig</returns>
        public async Task<GetAutoConfigResult> GetAutoConfigAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetAutoConfig", null);
            return new GetAutoConfigResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetDSLLinkType on service
        /// </summary>
        /// <param name="request">the request for the action SetDSLLinkType</param>
        public async Task SetDSLLinkTypeAsync(SetDSLLinkTypeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewLinkType", request.LinkType.ToString())
            };
            await base.InvokeAsync("SetDSLLinkType", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetDSLLinkInfo on service
        /// </summary>
        /// <returns>the result of the action GetDSLLinkInfo</returns>
        public async Task<GetDSLLinkInfoResult> GetDSLLinkInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetDSLLinkInfo", null);
            return new GetDSLLinkInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetDestinationAddress on service
        /// </summary>
        /// <param name="request">the request for the action SetDestinationAddress</param>
        public async Task SetDestinationAddressAsync(SetDestinationAddressRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewDestinationAddress", request.DestinationAddress.ToString())
            };
            await base.InvokeAsync("SetDestinationAddress", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetDestinationAddress on service
        /// </summary>
        /// <returns>the result of the action GetDestinationAddress</returns>
        public async Task<GetDestinationAddressResult> GetDestinationAddressAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetDestinationAddress", null);
            return new GetDestinationAddressResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetATMEncapsulation on service
        /// </summary>
        /// <param name="request">the request for the action SetATMEncapsulation</param>
        public async Task SetATMEncapsulationAsync(SetATMEncapsulationRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewATMEncapsulation", request.ATMEncapsulation.ToString())
            };
            await base.InvokeAsync("SetATMEncapsulation", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetATMEncapsulation on service
        /// </summary>
        /// <returns>the result of the action GetATMEncapsulation</returns>
        public async Task<GetATMEncapsulationResult> GetATMEncapsulationAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetATMEncapsulation", null);
            return new GetATMEncapsulationResult(soapResult);
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