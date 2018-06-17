using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Storage
{
    /// <summary>
    /// client proxy class for X_Storage service
    /// </summary>
    public class X_StorageService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for X_StorageService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public X_StorageService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for X_StorageService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public X_StorageService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for X_StorageService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public X_StorageService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for X_StorageService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public X_StorageService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/x_storage";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:X_AVM-DE_Storage:1";
		
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
        /// method to invoke SetFTPServer on service
        /// </summary>
        /// <param name="request">the request for the action SetFTPServer</param>
        public async Task SetFTPServerAsync(SetFTPServerRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewFTPEnable", request.FTPEnable ? "1" : "0")
            };
            await base.InvokeAsync("SetFTPServer", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetFTPServerWAN on service
        /// </summary>
        /// <param name="request">the request for the action SetFTPServerWAN</param>
        public async Task SetFTPServerWANAsync(SetFTPServerWANRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewFTPWANEnable", request.FTPWANEnable ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewFTPWANSSLOnly", request.FTPWANSSLOnly ? "1" : "0")
            };
            await base.InvokeAsync("SetFTPServerWAN", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetSMBServer on service
        /// </summary>
        /// <param name="request">the request for the action SetSMBServer</param>
        public async Task SetSMBServerAsync(SetSMBServerRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewSMBEnable", request.SMBEnable ? "1" : "0")
            };
            await base.InvokeAsync("SetSMBServer", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetUserInfo on service
        /// </summary>
        /// <returns>the result of the action GetUserInfo</returns>
        public async Task<GetUserInfoResult> GetUserInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetUserInfo", null);
            return new GetUserInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetUserConfig on service
        /// </summary>
        /// <param name="request">the request for the action SetUserConfig</param>
        public async Task SetUserConfigAsync(SetUserConfigRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewEnable", request.Enable ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewPassword", request.Password.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_NetworkAccessReadOnly", request.NetworkAccessReadOnly ? "1" : "0")
            };
            await base.InvokeAsync("SetUserConfig", parameters.ToArray());
        }

        #endregion
    }
}