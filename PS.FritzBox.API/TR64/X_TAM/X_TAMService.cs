using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_TAM
{
    /// <summary>
    /// client proxy class for X_TAM service
    /// </summary>
    public class X_TAMService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for X_TAMService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public X_TAMService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for X_TAMService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public X_TAMService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for X_TAMService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public X_TAMService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for X_TAMService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public X_TAMService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/x_tam";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:X_AVM-DE_TAM:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke GetInfo on service
        /// </summary>
        /// <param name="request">the request for the action GetInfo</param>
        /// <returns>the result of the action GetInfo</returns>
        public async Task<GetInfoResult> GetInfoAsync(GetInfoRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetInfo", parameters.ToArray());
            return new GetInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetEnable on service
        /// </summary>
        /// <param name="request">the request for the action SetEnable</param>
        public async Task SetEnableAsync(SetEnableRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString()),
                new SOAP.SoapRequestParameter("NewEnable", request.Enable ? "1" : "0")
            };
            await base.InvokeAsync("SetEnable", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetMessageList on service
        /// </summary>
        /// <param name="request">the request for the action GetMessageList</param>
        /// <returns>the result of the action GetMessageList</returns>
        public async Task<GetMessageListResult> GetMessageListAsync(GetMessageListRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetMessageList", parameters.ToArray());
            return new GetMessageListResult(soapResult);
        }

        /// <summary>
        /// method to invoke MarkMessage on service
        /// </summary>
        /// <param name="request">the request for the action MarkMessage</param>
        public async Task MarkMessageAsync(MarkMessageRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString()),
                new SOAP.SoapRequestParameter("NewMessageIndex", request.MessageIndex.ToString())
            };
            await base.InvokeAsync("MarkMessage", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke DeleteMessage on service
        /// </summary>
        /// <param name="request">the request for the action DeleteMessage</param>
        public async Task DeleteMessageAsync(DeleteMessageRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString()),
                new SOAP.SoapRequestParameter("NewMessageIndex", request.MessageIndex.ToString())
            };
            await base.InvokeAsync("DeleteMessage", parameters.ToArray());
        }

        #endregion
    }
}