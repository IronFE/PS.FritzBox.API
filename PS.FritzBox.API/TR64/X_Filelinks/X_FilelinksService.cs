using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Filelinks
{
    /// <summary>
    /// client proxy class for X_Filelinks service
    /// </summary>
    public class X_FilelinksService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for X_FilelinksService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public X_FilelinksService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for X_FilelinksService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public X_FilelinksService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for X_FilelinksService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public X_FilelinksService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for X_FilelinksService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public X_FilelinksService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/x_filelinks";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:X_AVM-DE_Filelinks:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke GetNumberOfFilelinkEntries on service
        /// </summary>
        /// <returns>the result of the action GetNumberOfFilelinkEntries</returns>
        public async Task<GetNumberOfFilelinkEntriesResult> GetNumberOfFilelinkEntriesAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetNumberOfFilelinkEntries", null);
            return new GetNumberOfFilelinkEntriesResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetGenericFilelinkEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetGenericFilelinkEntry</param>
        /// <returns>the result of the action GetGenericFilelinkEntry</returns>
        public async Task<GetGenericFilelinkEntryResult> GetGenericFilelinkEntryAsync(GetGenericFilelinkEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetGenericFilelinkEntry", parameters.ToArray());
            return new GetGenericFilelinkEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetSpecificFilelinkEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetSpecificFilelinkEntry</param>
        /// <returns>the result of the action GetSpecificFilelinkEntry</returns>
        public async Task<GetSpecificFilelinkEntryResult> GetSpecificFilelinkEntryAsync(GetSpecificFilelinkEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewID", request.ID.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetSpecificFilelinkEntry", parameters.ToArray());
            return new GetSpecificFilelinkEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke NewFilelinkEntry on service
        /// </summary>
        /// <param name="request">the request for the action NewFilelinkEntry</param>
        /// <returns>the result of the action NewFilelinkEntry</returns>
        public async Task<NewFilelinkEntryResult> NewFilelinkEntryAsync(NewFilelinkEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPath", request.Path.ToString()),
                new SOAP.SoapRequestParameter("NewAccessCountLimit", request.AccessCountLimit.ToString()),
                new SOAP.SoapRequestParameter("NewExpire", request.Expire.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("NewFilelinkEntry", parameters.ToArray());
            return new NewFilelinkEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetFilelinkEntry on service
        /// </summary>
        /// <param name="request">the request for the action SetFilelinkEntry</param>
        public async Task SetFilelinkEntryAsync(SetFilelinkEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewID", request.ID.ToString()),
                new SOAP.SoapRequestParameter("NewAccessCountLimit", request.AccessCountLimit.ToString()),
                new SOAP.SoapRequestParameter("NewExpire", request.Expire.ToString())
            };
            await base.InvokeAsync("SetFilelinkEntry", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke DeleteFilelinkEntry on service
        /// </summary>
        /// <param name="request">the request for the action DeleteFilelinkEntry</param>
        public async Task DeleteFilelinkEntryAsync(DeleteFilelinkEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewID", request.ID.ToString())
            };
            await base.InvokeAsync("DeleteFilelinkEntry", parameters.ToArray());
        }

        #endregion
    }
}