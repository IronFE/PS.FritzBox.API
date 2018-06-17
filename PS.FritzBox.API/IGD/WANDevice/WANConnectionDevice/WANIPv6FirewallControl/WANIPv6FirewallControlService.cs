using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANIPv6FirewallControl
{
    /// <summary>
    /// client proxy class for WANIPv6FirewallControl service
    /// </summary>
    public class WANIPv6FirewallControlService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for WANIPv6FirewallControlService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public WANIPv6FirewallControlService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for WANIPv6FirewallControlService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public WANIPv6FirewallControlService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for WANIPv6FirewallControlService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public WANIPv6FirewallControlService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for WANIPv6FirewallControlService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public WANIPv6FirewallControlService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/igd2upnp/control/WANIPv6Firewall1";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:schemas-upnp-org:service:WANIPv6FirewallControl:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke GetFirewallStatus on service
        /// </summary>
        /// <returns>the result of the action GetFirewallStatus</returns>
        public async Task<GetFirewallStatusResult> GetFirewallStatusAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetFirewallStatus", null);
            return new GetFirewallStatusResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetOutboundPinholeTimeout on service
        /// </summary>
        /// <param name="request">the request for the action GetOutboundPinholeTimeout</param>
        /// <returns>the result of the action GetOutboundPinholeTimeout</returns>
        public async Task<GetOutboundPinholeTimeoutResult> GetOutboundPinholeTimeoutAsync(GetOutboundPinholeTimeoutRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("RemoteHost", request.RemoteHost.ToString()),
                new SOAP.SoapRequestParameter("RemotePort", request.RemotePort.ToString()),
                new SOAP.SoapRequestParameter("InternalClient", request.InternalClient.ToString()),
                new SOAP.SoapRequestParameter("InternalPort", request.InternalPort.ToString()),
                new SOAP.SoapRequestParameter("Protocol", request.Protocol.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetOutboundPinholeTimeout", parameters.ToArray());
            return new GetOutboundPinholeTimeoutResult(soapResult);
        }

        /// <summary>
        /// method to invoke AddPinhole on service
        /// </summary>
        /// <param name="request">the request for the action AddPinhole</param>
        /// <returns>the result of the action AddPinhole</returns>
        public async Task<AddPinholeResult> AddPinholeAsync(AddPinholeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("RemoteHost", request.RemoteHost.ToString()),
                new SOAP.SoapRequestParameter("RemotePort", request.RemotePort.ToString()),
                new SOAP.SoapRequestParameter("InternalClient", request.InternalClient.ToString()),
                new SOAP.SoapRequestParameter("InternalPort", request.InternalPort.ToString()),
                new SOAP.SoapRequestParameter("Protocol", request.Protocol.ToString()),
                new SOAP.SoapRequestParameter("LeaseTime", request.LeaseTime.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("AddPinhole", parameters.ToArray());
            return new AddPinholeResult(soapResult);
        }

        /// <summary>
        /// method to invoke UpdatePinhole on service
        /// </summary>
        /// <param name="request">the request for the action UpdatePinhole</param>
        public async Task UpdatePinholeAsync(UpdatePinholeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("UniqueID", request.UniqueID.ToString()),
                new SOAP.SoapRequestParameter("NewLeaseTime", request.LeaseTime.ToString())
            };
            await base.InvokeAsync("UpdatePinhole", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke DeletePinhole on service
        /// </summary>
        /// <param name="request">the request for the action DeletePinhole</param>
        public async Task DeletePinholeAsync(DeletePinholeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("UniqueID", request.UniqueID.ToString())
            };
            await base.InvokeAsync("DeletePinhole", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetPinholePackets on service
        /// </summary>
        /// <param name="request">the request for the action GetPinholePackets</param>
        /// <returns>the result of the action GetPinholePackets</returns>
        public async Task<GetPinholePacketsResult> GetPinholePacketsAsync(GetPinholePacketsRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("UniqueID", request.UniqueID.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetPinholePackets", parameters.ToArray());
            return new GetPinholePacketsResult(soapResult);
        }

        /// <summary>
        /// method to invoke CheckPinholeWorking on service
        /// </summary>
        /// <param name="request">the request for the action CheckPinholeWorking</param>
        /// <returns>the result of the action CheckPinholeWorking</returns>
        public async Task<CheckPinholeWorkingResult> CheckPinholeWorkingAsync(CheckPinholeWorkingRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("UniqueID", request.UniqueID.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("CheckPinholeWorking", parameters.ToArray());
            return new CheckPinholeWorkingResult(soapResult);
        }

        #endregion
    }
}