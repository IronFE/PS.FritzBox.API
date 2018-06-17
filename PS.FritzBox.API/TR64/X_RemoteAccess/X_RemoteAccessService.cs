using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_RemoteAccess
{
    /// <summary>
    /// client proxy class for X_RemoteAccess service
    /// </summary>
    public class X_RemoteAccessService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for X_RemoteAccessService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public X_RemoteAccessService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for X_RemoteAccessService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public X_RemoteAccessService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for X_RemoteAccessService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public X_RemoteAccessService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for X_RemoteAccessService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public X_RemoteAccessService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/x_remote";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1";
		
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
        public async Task<GetInfoResult> GetInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetInfo", null);
            return new GetInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetConfig on service
        /// </summary>
        /// <param name="request">the request for the action SetConfig</param>
        public async Task SetConfigAsync(SetConfigRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewEnabled", request.Enabled ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewPort", request.Port.ToString()),
                new SOAP.SoapRequestParameter("NewUsername", request.Username.ToString()),
                new SOAP.SoapRequestParameter("NewPassword", request.Password.ToString())
            };
            await base.InvokeAsync("SetConfig", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetDDNSInfo on service
        /// </summary>
        /// <returns>the result of the action GetDDNSInfo</returns>
        public async Task<GetDDNSInfoResult> GetDDNSInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetDDNSInfo", null);
            return new GetDDNSInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetDDNSProviders on service
        /// </summary>
        /// <returns>the result of the action GetDDNSProviders</returns>
        public async Task<GetDDNSProvidersResult> GetDDNSProvidersAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetDDNSProviders", null);
            return new GetDDNSProvidersResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetDDNSConfig on service
        /// </summary>
        /// <param name="request">the request for the action SetDDNSConfig</param>
        public async Task SetDDNSConfigAsync(SetDDNSConfigRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewEnabled", request.Enabled ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewProviderName", request.ProviderName.ToString()),
                new SOAP.SoapRequestParameter("NewUpdateURL", request.UpdateURL.ToString()),
                new SOAP.SoapRequestParameter("NewDomain", request.Domain.ToString()),
                new SOAP.SoapRequestParameter("NewUsername", request.Username.ToString()),
                new SOAP.SoapRequestParameter("NewMode", request.Mode.ToString()),
                new SOAP.SoapRequestParameter("NewServerIPv4", request.ServerIPv4.ToString()),
                new SOAP.SoapRequestParameter("NewServerIPv6", request.ServerIPv6.ToString()),
                new SOAP.SoapRequestParameter("NewPassword", request.Password.ToString())
            };
            await base.InvokeAsync("SetDDNSConfig", parameters.ToArray());
        }

        #endregion
    }
}