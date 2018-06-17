using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANConfigSecurity
{
    /// <summary>
    /// client proxy class for LANConfigSecurity service
    /// </summary>
    public class LANConfigSecurityService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for LANConfigSecurityService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public LANConfigSecurityService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for LANConfigSecurityService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public LANConfigSecurityService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for LANConfigSecurityService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public LANConfigSecurityService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for LANConfigSecurityService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public LANConfigSecurityService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/lanconfigsecurity";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:LANConfigSecurity:1";
		
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
        /// method to invoke X_AVM-DE_GetCurrentUser on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetCurrentUser</returns>
        public async Task<X_GetCurrentUserResult> X_GetCurrentUserAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetCurrentUser", null);
            return new X_GetCurrentUserResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetAnonymousLogin on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetAnonymousLogin</returns>
        public async Task<X_GetAnonymousLoginResult> X_GetAnonymousLoginAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetAnonymousLogin", null);
            return new X_GetAnonymousLoginResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetConfigPassword on service
        /// </summary>
        /// <param name="request">the request for the action SetConfigPassword</param>
        public async Task SetConfigPasswordAsync(SetConfigPasswordRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPassword", request.Password.ToString())
            };
            await base.InvokeAsync("SetConfigPassword", parameters.ToArray());
        }

        #endregion
    }
}