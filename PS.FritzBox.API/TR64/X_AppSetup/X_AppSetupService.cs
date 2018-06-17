using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_AppSetup
{
    /// <summary>
    /// client proxy class for X_AppSetup service
    /// </summary>
    public class X_AppSetupService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for X_AppSetupService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public X_AppSetupService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for X_AppSetupService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public X_AppSetupService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for X_AppSetupService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public X_AppSetupService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for X_AppSetupService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public X_AppSetupService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/x_appsetup";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:X_AVM-DE_AppSetup:1";
		
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
        /// method to invoke GetConfig on service
        /// </summary>
        /// <returns>the result of the action GetConfig</returns>
        public async Task<GetConfigResult> GetConfigAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetConfig", null);
            return new GetConfigResult(soapResult);
        }

        /// <summary>
        /// method to invoke RegisterApp on service
        /// </summary>
        /// <param name="request">the request for the action RegisterApp</param>
        public async Task RegisterAppAsync(RegisterAppRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewAppId", request.AppId.ToString()),
                new SOAP.SoapRequestParameter("NewAppDisplayName", request.AppDisplayName.ToString()),
                new SOAP.SoapRequestParameter("NewAppDeviceMAC", request.AppDeviceMAC.ToString()),
                new SOAP.SoapRequestParameter("NewAppUsername", request.AppUsername.ToString()),
                new SOAP.SoapRequestParameter("NewAppPassword", request.AppPassword.ToString()),
                new SOAP.SoapRequestParameter("NewAppRight", request.AppRight.ToString()),
                new SOAP.SoapRequestParameter("NewNasRight", request.NasRight.ToString()),
                new SOAP.SoapRequestParameter("NewPhoneRight", request.PhoneRight.ToString()),
                new SOAP.SoapRequestParameter("NewHomeautoRight", request.HomeautoRight.ToString()),
                new SOAP.SoapRequestParameter("NewAppInternetRights", request.AppInternetRights ? "1" : "0")
            };
            await base.InvokeAsync("RegisterApp", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetAppVPN on service
        /// </summary>
        /// <param name="request">the request for the action SetAppVPN</param>
        public async Task SetAppVPNAsync(SetAppVPNRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewAppId", request.AppId.ToString()),
                new SOAP.SoapRequestParameter("NewIPSecIdentifier", request.IPSecIdentifier.ToString()),
                new SOAP.SoapRequestParameter("NewIPSecPreSharedKey", request.IPSecPreSharedKey.ToString()),
                new SOAP.SoapRequestParameter("NewIPSecXauthUsername", request.IPSecXauthUsername.ToString()),
                new SOAP.SoapRequestParameter("NewIPSecXauthPassword", request.IPSecXauthPassword.ToString())
            };
            await base.InvokeAsync("SetAppVPN", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetAppMessageReceiver on service
        /// </summary>
        /// <param name="request">the request for the action SetAppMessageReceiver</param>
        /// <returns>the result of the action SetAppMessageReceiver</returns>
        public async Task<SetAppMessageReceiverResult> SetAppMessageReceiverAsync(SetAppMessageReceiverRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewAppId", request.AppId.ToString()),
                new SOAP.SoapRequestParameter("NewCryptAlgos", request.CryptAlgos.ToString()),
                new SOAP.SoapRequestParameter("NewAppAVMAddress", request.AppAVMAddress.ToString()),
                new SOAP.SoapRequestParameter("NewAppAVMPasswordHash", request.AppAVMPasswordHash.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("SetAppMessageReceiver", parameters.ToArray());
            return new SetAppMessageReceiverResult(soapResult);
        }

        #endregion
    }
}