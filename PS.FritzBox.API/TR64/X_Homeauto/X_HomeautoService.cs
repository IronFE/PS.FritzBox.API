using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Homeauto
{
    /// <summary>
    /// client proxy class for X_Homeauto service
    /// </summary>
    public class X_HomeautoService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for X_HomeautoService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public X_HomeautoService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for X_HomeautoService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public X_HomeautoService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for X_HomeautoService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public X_HomeautoService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for X_HomeautoService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public X_HomeautoService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/x_homeauto";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:X_AVM-DE_Homeauto:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke GetGenericDeviceInfos on service
        /// </summary>
        /// <param name="request">the request for the action GetGenericDeviceInfos</param>
        /// <returns>the result of the action GetGenericDeviceInfos</returns>
        public async Task<GetGenericDeviceInfosResult> GetGenericDeviceInfosAsync(GetGenericDeviceInfosRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetGenericDeviceInfos", parameters.ToArray());
            return new GetGenericDeviceInfosResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetSpecificDeviceInfos on service
        /// </summary>
        /// <param name="request">the request for the action GetSpecificDeviceInfos</param>
        /// <returns>the result of the action GetSpecificDeviceInfos</returns>
        public async Task<GetSpecificDeviceInfosResult> GetSpecificDeviceInfosAsync(GetSpecificDeviceInfosRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewAIN", request.AIN.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetSpecificDeviceInfos", parameters.ToArray());
            return new GetSpecificDeviceInfosResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetSwitch on service
        /// </summary>
        /// <param name="request">the request for the action SetSwitch</param>
        public async Task SetSwitchAsync(SetSwitchRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewAIN", request.AIN.ToString()),
                new SOAP.SoapRequestParameter("NewSwitchState", request.SwitchState.ToString())
            };
            await base.InvokeAsync("SetSwitch", parameters.ToArray());
        }

        #endregion
    }
}