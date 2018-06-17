using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.UserInterface
{
    /// <summary>
    /// client proxy class for UserInterface service
    /// </summary>
    public class UserInterfaceService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for UserInterfaceService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public UserInterfaceService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for UserInterfaceService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public UserInterfaceService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for UserInterfaceService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public UserInterfaceService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for UserInterfaceService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public UserInterfaceService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/userif";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:UserInterface:1";
		
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
        /// method to invoke X_AVM-DE_CheckUpdate on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_CheckUpdate</param>
        public async Task X_CheckUpdateAsync(X_CheckUpdateRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_LaborVersion", request.LaborVersion.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_CheckUpdate", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_DoUpdate on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_DoUpdate</returns>
        public async Task<X_DoUpdateResult> X_DoUpdateAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_DoUpdate", null);
            return new X_DoUpdateResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_DoPrepareCGI on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_DoPrepareCGI</returns>
        public async Task<X_DoPrepareCGIResult> X_DoPrepareCGIAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_DoPrepareCGI", null);
            return new X_DoPrepareCGIResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_DoManualUpdate on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_DoManualUpdate</param>
        public async Task X_DoManualUpdateAsync(X_DoManualUpdateRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_AllowDowngrade", request.AllowDowngrade ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_DownloadURL", request.DownloadURL.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_DoManualUpdate", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetInternationalConfig on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetInternationalConfig</returns>
        public async Task<X_GetInternationalConfigResult> X_GetInternationalConfigAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetInternationalConfig", null);
            return new X_GetInternationalConfigResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetInternationalConfig on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetInternationalConfig</param>
        public async Task X_SetInternationalConfigAsync(X_SetInternationalConfigRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_Language", request.Language.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_Country", request.Country.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_Annex", request.Annex.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_SetInternationalConfig", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetInfo on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetInfo</returns>
        public async Task<X_GetInfoResult> X_GetInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetInfo", null);
            return new X_GetInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetConfig on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetConfig</param>
        public async Task X_SetConfigAsync(X_SetConfigRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_AutoUpdateMode", request.AutoUpdateMode.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_SetConfig", parameters.ToArray());
        }

        #endregion
    }
}