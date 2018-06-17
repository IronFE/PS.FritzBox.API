using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANIPConnection
{
    /// <summary>
    /// client proxy class for WANIPConnection service
    /// </summary>
    public class WANIPConnectionService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for WANIPConnectionService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public WANIPConnectionService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for WANIPConnectionService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public WANIPConnectionService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for WANIPConnectionService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public WANIPConnectionService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for WANIPConnectionService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public WANIPConnectionService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/igdupnp/control/WANIPConn1";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:schemas-upnp-org:service:WANIPConnection:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

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
        /// method to invoke GetConnectionTypeInfo on service
        /// </summary>
        /// <returns>the result of the action GetConnectionTypeInfo</returns>
        public async Task<GetConnectionTypeInfoResult> GetConnectionTypeInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetConnectionTypeInfo", null);
            return new GetConnectionTypeInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetAutoDisconnectTime on service
        /// </summary>
        /// <returns>the result of the action GetAutoDisconnectTime</returns>
        public async Task<GetAutoDisconnectTimeResult> GetAutoDisconnectTimeAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetAutoDisconnectTime", null);
            return new GetAutoDisconnectTimeResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetIdleDisconnectTime on service
        /// </summary>
        /// <returns>the result of the action GetIdleDisconnectTime</returns>
        public async Task<GetIdleDisconnectTimeResult> GetIdleDisconnectTimeAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetIdleDisconnectTime", null);
            return new GetIdleDisconnectTimeResult(soapResult);
        }

        /// <summary>
        /// method to invoke RequestConnection on service
        /// </summary>
        public async Task RequestConnectionAsync()
        {
            await base.InvokeAsync("RequestConnection", null);
        }

        /// <summary>
        /// method to invoke RequestTermination on service
        /// </summary>
        public async Task RequestTerminationAsync()
        {
            await base.InvokeAsync("RequestTermination", null);
        }

        /// <summary>
        /// method to invoke ForceTermination on service
        /// </summary>
        public async Task ForceTerminationAsync()
        {
            await base.InvokeAsync("ForceTermination", null);
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
        /// method to invoke GetNATRSIPStatus on service
        /// </summary>
        /// <returns>the result of the action GetNATRSIPStatus</returns>
        public async Task<GetNATRSIPStatusResult> GetNATRSIPStatusAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetNATRSIPStatus", null);
            return new GetNATRSIPStatusResult(soapResult);
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
        /// method to invoke X_AVM_DE_GetExternalIPv6Address on service
        /// </summary>
        /// <returns>the result of the action X_AVM_DE_GetExternalIPv6Address</returns>
        public async Task<X_AVM_DE_GetExternalIPv6AddressResult> X_AVM_DE_GetExternalIPv6AddressAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM_DE_GetExternalIPv6Address", null);
            return new X_AVM_DE_GetExternalIPv6AddressResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM_DE_GetIPv6Prefix on service
        /// </summary>
        /// <returns>the result of the action X_AVM_DE_GetIPv6Prefix</returns>
        public async Task<X_AVM_DE_GetIPv6PrefixResult> X_AVM_DE_GetIPv6PrefixAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM_DE_GetIPv6Prefix", null);
            return new X_AVM_DE_GetIPv6PrefixResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM_DE_GetDNSServer on service
        /// </summary>
        /// <returns>the result of the action X_AVM_DE_GetDNSServer</returns>
        public async Task<X_AVM_DE_GetDNSServerResult> X_AVM_DE_GetDNSServerAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM_DE_GetDNSServer", null);
            return new X_AVM_DE_GetDNSServerResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM_DE_GetIPv6DNSServer on service
        /// </summary>
        /// <returns>the result of the action X_AVM_DE_GetIPv6DNSServer</returns>
        public async Task<X_AVM_DE_GetIPv6DNSServerResult> X_AVM_DE_GetIPv6DNSServerAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM_DE_GetIPv6DNSServer", null);
            return new X_AVM_DE_GetIPv6DNSServerResult(soapResult);
        }

        #endregion
    }
}