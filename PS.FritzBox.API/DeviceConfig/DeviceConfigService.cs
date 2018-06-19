using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API
{
    /// <summary>
    /// client proxy class for DeviceConfig service
    /// </summary>
    public class DeviceConfigService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for DeviceConfigService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public DeviceConfigService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for DeviceConfigService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public DeviceConfigService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for DeviceConfigService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public DeviceConfigService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for DeviceConfigService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public DeviceConfigService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/deviceconfig";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:DeviceConfig:1";
		
        #endregion

        #region Methods

        /// <summary>
        /// method to invoke GetPersistentData on service
        /// </summary>
        /// <returns>the result of the action GetPersistentData</returns>
        public async Task<GetPersistentDataResult> GetPersistentDataAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetPersistentData", null);
            return new GetPersistentDataResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetPersistentData on service
        /// </summary>
        /// <param name="request">the request for the action SetPersistentData</param>
        public async Task SetPersistentDataAsync(SetPersistentDataRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPersistentData", request.PersistentData.ToString())
            };
            await base.InvokeAsync("SetPersistentData", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke ConfigurationStarted on service
        /// </summary>
        /// <param name="request">the request for the action ConfigurationStarted</param>
        public async Task ConfigurationStartedAsync(ConfigurationStartedRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewSessionID", request.SessionID.ToString())
            };
            await base.InvokeAsync("ConfigurationStarted", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke ConfigurationFinished on service
        /// </summary>
        /// <returns>the result of the action ConfigurationFinished</returns>
        public async Task<ConfigurationFinishedResult> ConfigurationFinishedAsync()
        {
            XDocument soapResult = await base.InvokeAsync("ConfigurationFinished", null);
            return new ConfigurationFinishedResult(soapResult);
        }

        /// <summary>
        /// method to invoke FactoryReset on service
        /// </summary>
        public async Task FactoryResetAsync()
        {
            await base.InvokeAsync("FactoryReset", null);
        }

        /// <summary>
        /// method to invoke Reboot on service
        /// </summary>
        public async Task RebootAsync()
        {
            await base.InvokeAsync("Reboot", null);
        }

        /// <summary>
        /// method to invoke X_GenerateUUID on service
        /// </summary>
        /// <returns>the result of the action X_GenerateUUID</returns>
        public async Task<X_GenerateUUIDResult> X_GenerateUUIDAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_GenerateUUID", null);
            return new X_GenerateUUIDResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetConfigFile on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_GetConfigFile</param>
        /// <returns>the result of the action X_AVM-DE_GetConfigFile</returns>
        public async Task<X_GetConfigFileResult> X_GetConfigFileAsync(X_GetConfigFileRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_Password", request.Password.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetConfigFile", parameters.ToArray());
            return new X_GetConfigFileResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetConfigFile on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetConfigFile</param>
        public async Task X_SetConfigFileAsync(X_SetConfigFileRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_Password", request.Password.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ConfigFileUrl", request.ConfigFileUrl.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_SetConfigFile", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_CreateUrlSID on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_CreateUrlSID</returns>
        public async Task<X_CreateUrlSIDResult> X_CreateUrlSIDAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_CreateUrlSID", null);
            return new X_CreateUrlSIDResult(soapResult);
        }

        #endregion
    }
}