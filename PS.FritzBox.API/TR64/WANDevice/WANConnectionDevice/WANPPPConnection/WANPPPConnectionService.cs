using PS.FritzBox.API.Base;
using PS.FritzBox.API.WANDevice.WANConnectionDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANPPPConnection
{
    /// <summary>
    /// client proxy class for WANPPPConnection service
    /// </summary>
    public class WANPPPConnectionService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for WANPPPConnectionService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public WANPPPConnectionService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for WANPPPConnectionService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public WANPPPConnectionService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for WANPPPConnectionService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public WANPPPConnectionService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for WANPPPConnectionService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public WANPPPConnectionService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/wanpppconn1";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:WANPPPConnection:1";
		
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
        public async Task<GetWANPPPConnectionInfoRequest> GetWANPPPConnectionInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetInfo", null);
            return new GetWANPPPConnectionInfoRequest(soapResult);
        }

        /// <summary>
        /// method to invoke GetConnectionTypeInfo on service
        /// </summary>
        /// <returns>the result of the action GetConnectionTypeInfo</returns>
        public async Task<GetConnectionTypeInfoResult> GetConnectionTypeInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetConnectionTypeInfo", null);
            return new GetConnectionTypeInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetConnectionType on service
        /// </summary>
        /// <param name="request">the request for the action SetConnectionType</param>
        public async Task SetConnectionTypeAsync(SetConnectionTypeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewConnectionType", request.ConnectionType.ToString())
            };
            await base.InvokeAsync("SetConnectionType", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetStatusInfo on service
        /// </summary>
        /// <returns>the result of the action GetStatusInfo</returns>
        public async Task<GetStatusInfoResult> GetStatusInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetStatusInfo", null);
            return new GetStatusInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetUserName on service
        /// </summary>
        /// <returns>the result of the action GetUserName</returns>
        public async Task<GetUserNameResult> GetUserNameAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetUserName", null);
            return new GetUserNameResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetUserName on service
        /// </summary>
        /// <param name="request">the request for the action SetUserName</param>
        public async Task SetUserNameAsync(SetUserNameRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewUserName", request.UserName.ToString())
            };
            await base.InvokeAsync("SetUserName", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetPassword on service
        /// </summary>
        /// <param name="request">the request for the action SetPassword</param>
        public async Task SetPasswordAsync(SetPasswordRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPassword", request.Password.ToString())
            };
            await base.InvokeAsync("SetPassword", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetNATRSIPStatus on service
        /// </summary>
        /// <returns>the result of the action GetNATRSIPStatus</returns>
        public async Task<GetNATRSIPStatusResult> GetNATRSIPStatusAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetNATRSIPStatus", null);
            return new GetNATRSIPStatusResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetConnectionTrigger on service
        /// </summary>
        /// <param name="request">the request for the action SetConnectionTrigger</param>
        public async Task SetConnectionTriggerAsync(SetConnectionTriggerRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewConnectionTrigger", request.ConnectionTrigger.ToString())
            };
            await base.InvokeAsync("SetConnectionTrigger", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke ForceTermination on service
        /// </summary>
        public async Task ForceTerminationAsync()
        {
            await base.InvokeAsync("ForceTermination", null);
        }

        /// <summary>
        /// method to invoke RequestConnection on service
        /// </summary>
        public async Task RequestConnectionAsync()
        {
            await base.InvokeAsync("RequestConnection", null);
        }

        /// <summary>
        /// method to invoke GetGenericPortMappingEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetGenericPortMappingEntry</param>
        /// <returns>the result of the action GetGenericPortMappingEntry</returns>
        public async Task<GetGenericPortMappingEntryResult> GetGenericPortMappingEntryAsync(GetGenericPortMappingEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPortMappingIndex", request.PortMappingIndex.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetGenericPortMappingEntry", parameters.ToArray());
            return new GetGenericPortMappingEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetSpecificPortMappingEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetSpecificPortMappingEntry</param>
        /// <returns>the result of the action GetSpecificPortMappingEntry</returns>
        public async Task<GetSpecificPortMappingEntryResult> GetSpecificPortMappingEntryAsync(GetSpecificPortMappingEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewRemoteHost", request.RemoteHost.ToString()),
                new SOAP.SoapRequestParameter("NewExternalPort", request.ExternalPort.ToString()),
                new SOAP.SoapRequestParameter("NewProtocol", request.Protocol.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetSpecificPortMappingEntry", parameters.ToArray());
            return new GetSpecificPortMappingEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke AddPortMapping on service
        /// </summary>
        /// <param name="request">the request for the action AddPortMapping</param>
        public async Task AddPortMappingAsync(AddPortMappingRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewRemoteHost", request.RemoteHost.ToString()),
                new SOAP.SoapRequestParameter("NewExternalPort", request.ExternalPort.ToString()),
                new SOAP.SoapRequestParameter("NewProtocol", request.Protocol.ToString()),
                new SOAP.SoapRequestParameter("NewInternalPort", request.InternalPort.ToString()),
                new SOAP.SoapRequestParameter("NewInternalClient", request.InternalClient.ToString()),
                new SOAP.SoapRequestParameter("NewEnabled", request.Enabled ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewPortMappingDescription", request.PortMappingDescription.ToString()),
                new SOAP.SoapRequestParameter("NewLeaseDuration", request.LeaseDuration.ToString())
            };
            await base.InvokeAsync("AddPortMapping", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke DeletePortMapping on service
        /// </summary>
        /// <param name="request">the request for the action DeletePortMapping</param>
        public async Task DeletePortMappingAsync(DeletePortMappingRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewRemoteHost", request.RemoteHost.ToString()),
                new SOAP.SoapRequestParameter("NewExternalPort", request.ExternalPort.ToString()),
                new SOAP.SoapRequestParameter("NewProtocol", request.Protocol.ToString())
            };
            await base.InvokeAsync("DeletePortMapping", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetExternalIPAddress on service
        /// </summary>
        /// <returns>the result of the action GetExternalIPAddress</returns>
        public async Task<GetExternalIPAddressResult> GetExternalIPAddressAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetExternalIPAddress", null);
            return new GetExternalIPAddressResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_GetDNSServers on service
        /// </summary>
        /// <returns>the result of the action X_GetDNSServers</returns>
        public async Task<X_GetDNSServersResult> X_GetDNSServersAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_GetDNSServers", null);
            return new X_GetDNSServersResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_SetDNSServers on service
        /// </summary>
        /// <param name="request">the request for the action X_SetDNSServers</param>
        public async Task X_SetDNSServersAsync(X_SetDNSServersRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewDNSServers", request.DNSServers.ToString())
            };
            await base.InvokeAsync("X_SetDNSServers", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetLinkLayerMaxBitRates on service
        /// </summary>
        /// <returns>the result of the action GetLinkLayerMaxBitRates</returns>
        public async Task<GetLinkLayerMaxBitRatesResult> GetLinkLayerMaxBitRatesAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetLinkLayerMaxBitRates", null);
            return new GetLinkLayerMaxBitRatesResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetPortMappingNumberOfEntries on service
        /// </summary>
        /// <returns>the result of the action GetPortMappingNumberOfEntries</returns>
        public async Task<GetPortMappingNumberOfEntriesResult> GetPortMappingNumberOfEntriesAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetPortMappingNumberOfEntries", null);
            return new GetPortMappingNumberOfEntriesResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetRouteProtocolRx on service
        /// </summary>
        /// <param name="request">the request for the action SetRouteProtocolRx</param>
        public async Task SetRouteProtocolRxAsync(SetRouteProtocolRxRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewRouteProtocolRx", request.RouteProtocolRx.ToString())
            };
            await base.InvokeAsync("SetRouteProtocolRx", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetIdleDisconnectTime on service
        /// </summary>
        /// <param name="request">the request for the action SetIdleDisconnectTime</param>
        public async Task SetIdleDisconnectTimeAsync(SetIdleDisconnectTimeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIdleDisconnectTime", request.IdleDisconnectTime.ToString())
            };
            await base.InvokeAsync("SetIdleDisconnectTime", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetAutoDisconnectTimeSpan on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetAutoDisconnectTimeSpan</returns>
        public async Task<X_GetAutoDisconnectTimeSpanResult> X_GetAutoDisconnectTimeSpanAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetAutoDisconnectTimeSpan", null);
            return new X_GetAutoDisconnectTimeSpanResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetAutoDisconnectTimeSpan on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetAutoDisconnectTimeSpan</param>
        public async Task X_SetAutoDisconnectTimeSpanAsync(X_SetAutoDisconnectTimeSpanRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_DisconnectPreventionEnable", request.DisconnectPreventionEnable ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_DisconnectPreventionHour", request.DisconnectPreventionHour.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_SetAutoDisconnectTimeSpan", parameters.ToArray());
        }

        #endregion
    }
}