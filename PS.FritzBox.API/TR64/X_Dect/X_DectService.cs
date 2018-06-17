using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Dect
{
    /// <summary>
    /// client proxy class for X_Dect service
    /// </summary>
    public class X_DectService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for X_DectService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public X_DectService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for X_DectService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public X_DectService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for X_DectService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public X_DectService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for X_DectService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public X_DectService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/x_dect";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:X_AVM-DE_Dect:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke GetNumberOfDectEntries on service
        /// </summary>
        /// <returns>the result of the action GetNumberOfDectEntries</returns>
        public async Task<GetNumberOfDectEntriesResult> GetNumberOfDectEntriesAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetNumberOfDectEntries", null);
            return new GetNumberOfDectEntriesResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetGenericDectEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetGenericDectEntry</param>
        /// <returns>the result of the action GetGenericDectEntry</returns>
        public async Task<GetGenericDectEntryResult> GetGenericDectEntryAsync(GetGenericDectEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetGenericDectEntry", parameters.ToArray());
            return new GetGenericDectEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetSpecificDectEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetSpecificDectEntry</param>
        /// <returns>the result of the action GetSpecificDectEntry</returns>
        public async Task<GetSpecificDectEntryResult> GetSpecificDectEntryAsync(GetSpecificDectEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewID", request.ID.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetSpecificDectEntry", parameters.ToArray());
            return new GetSpecificDectEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke DectDoUpdate on service
        /// </summary>
        /// <param name="request">the request for the action DectDoUpdate</param>
        public async Task DectDoUpdateAsync(DectDoUpdateRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewID", request.ID.ToString())
            };
            await base.InvokeAsync("DectDoUpdate", parameters.ToArray());
        }

        #endregion
    }
}