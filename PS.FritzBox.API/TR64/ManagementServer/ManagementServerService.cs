using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.ManagementServer
{
    /// <summary>
    /// client proxy class for ManagementServer service
    /// </summary>
    public class ManagementServerService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for ManagementServerService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public ManagementServerService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for ManagementServerService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public ManagementServerService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for ManagementServerService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public ManagementServerService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for ManagementServerService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public ManagementServerService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/mgmsrv";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:ManagementServer:1";
		
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
        /// method to invoke SetManagementServerURL on service
        /// </summary>
        /// <param name="request">the request for the action SetManagementServerURL</param>
        public async Task SetManagementServerURLAsync(SetManagementServerURLRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewURL", request.URL.ToString())
            };
            await base.InvokeAsync("SetManagementServerURL", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetManagementServerUsername on service
        /// </summary>
        /// <param name="request">the request for the action SetManagementServerUsername</param>
        public async Task SetManagementServerUsernameAsync(SetManagementServerUsernameRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewUsername", request.Username.ToString())
            };
            await base.InvokeAsync("SetManagementServerUsername", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetManagementServerPassword on service
        /// </summary>
        /// <param name="request">the request for the action SetManagementServerPassword</param>
        public async Task SetManagementServerPasswordAsync(SetManagementServerPasswordRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPassword", request.Password.ToString())
            };
            await base.InvokeAsync("SetManagementServerPassword", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetPeriodicInform on service
        /// </summary>
        /// <param name="request">the request for the action SetPeriodicInform</param>
        public async Task SetPeriodicInformAsync(SetPeriodicInformRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPeriodicInformEnable", request.PeriodicInformEnable ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewPeriodicInformInterval", request.PeriodicInformInterval.ToString()),
                new SOAP.SoapRequestParameter("NewPeriodicInformTime", request.PeriodicInformTime.ToString())
            };
            await base.InvokeAsync("SetPeriodicInform", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetConnectionRequestAuthentication on service
        /// </summary>
        /// <param name="request">the request for the action SetConnectionRequestAuthentication</param>
        public async Task SetConnectionRequestAuthenticationAsync(SetConnectionRequestAuthenticationRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewConnectionRequestUsername", request.ConnectionRequestUsername.ToString()),
                new SOAP.SoapRequestParameter("NewConnectionRequestPassword", request.ConnectionRequestPassword.ToString())
            };
            await base.InvokeAsync("SetConnectionRequestAuthentication", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetUpgradeManagement on service
        /// </summary>
        /// <param name="request">the request for the action SetUpgradeManagement</param>
        public async Task SetUpgradeManagementAsync(SetUpgradeManagementRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewUpgradesManaged", request.UpgradesManaged ? "1" : "0")
            };
            await base.InvokeAsync("SetUpgradeManagement", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_SetTR069Enable on service
        /// </summary>
        /// <param name="request">the request for the action X_SetTR069Enable</param>
        public async Task X_SetTR069EnableAsync(X_SetTR069EnableRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewTR069Enabled", request.TR069Enabled ? "1" : "0")
            };
            await base.InvokeAsync("X_SetTR069Enable", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetTR069FirmwareDownloadEnabled on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetTR069FirmwareDownloadEnabled</returns>
        public async Task<X_GetTR069FirmwareDownloadEnabledResult> X_GetTR069FirmwareDownloadEnabledAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetTR069FirmwareDownloadEnabled", null);
            return new X_GetTR069FirmwareDownloadEnabledResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetTR069FirmwareDownloadEnabled on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetTR069FirmwareDownloadEnabled</param>
        public async Task X_SetTR069FirmwareDownloadEnabledAsync(X_SetTR069FirmwareDownloadEnabledRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewTR069FirmwareDownloadEnabled", request.TR069FirmwareDownloadEnabled ? "1" : "0")
            };
            await base.InvokeAsync("X_AVM-DE_SetTR069FirmwareDownloadEnabled", parameters.ToArray());
        }

        #endregion
    }
}