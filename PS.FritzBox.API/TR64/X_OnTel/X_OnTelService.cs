using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// client proxy class for X_OnTel service
    /// </summary>
    public class X_OnTelService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for X_OnTelService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public X_OnTelService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for X_OnTelService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public X_OnTelService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for X_OnTelService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public X_OnTelService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for X_OnTelService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public X_OnTelService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/x_contact";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:X_AVM-DE_OnTel:1";
		
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
        /// method to invoke SetEnable on service
        /// </summary>
        /// <param name="request">the request for the action SetEnable</param>
        public async Task SetEnableAsync(SetEnableRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewEnable", request.Enable ? "1" : "0")
            };
            await base.InvokeAsync("SetEnable", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetConfig on service
        /// </summary>
        /// <param name="request">the request for the action SetConfig</param>
        public async Task SetConfigAsync(SetConfigRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewEnable", request.Enable ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewUrl", request.Url.ToString()),
                new SOAP.SoapRequestParameter("NewServiceId", request.ServiceId.ToString()),
                new SOAP.SoapRequestParameter("NewUsername", request.Username.ToString()),
                new SOAP.SoapRequestParameter("NewPassword", request.Password.ToString()),
                new SOAP.SoapRequestParameter("NewName", request.Name.ToString())
            };
            await base.InvokeAsync("SetConfig", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetInfoByIndex on service
        /// </summary>
        /// <param name="request">the request for the action GetInfoByIndex</param>
        /// <returns>the result of the action GetInfoByIndex</returns>
        public async Task<GetInfoByIndexResult> GetInfoByIndexAsync(GetInfoByIndexRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetInfoByIndex", parameters.ToArray());
            return new GetInfoByIndexResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetEnableByIndex on service
        /// </summary>
        /// <param name="request">the request for the action SetEnableByIndex</param>
        public async Task SetEnableByIndexAsync(SetEnableByIndexRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString()),
                new SOAP.SoapRequestParameter("NewEnable", request.Enable ? "1" : "0")
            };
            await base.InvokeAsync("SetEnableByIndex", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetConfigByIndex on service
        /// </summary>
        /// <param name="request">the request for the action SetConfigByIndex</param>
        public async Task SetConfigByIndexAsync(SetConfigByIndexRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString()),
                new SOAP.SoapRequestParameter("NewEnable", request.Enable ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewUrl", request.Url.ToString()),
                new SOAP.SoapRequestParameter("NewServiceId", request.ServiceId.ToString()),
                new SOAP.SoapRequestParameter("NewUsername", request.Username.ToString()),
                new SOAP.SoapRequestParameter("NewPassword", request.Password.ToString()),
                new SOAP.SoapRequestParameter("NewName", request.Name.ToString())
            };
            await base.InvokeAsync("SetConfigByIndex", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke DeleteByIndex on service
        /// </summary>
        /// <param name="request">the request for the action DeleteByIndex</param>
        public async Task DeleteByIndexAsync(DeleteByIndexRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString())
            };
            await base.InvokeAsync("DeleteByIndex", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetNumberOfEntries on service
        /// </summary>
        /// <returns>the result of the action GetNumberOfEntries</returns>
        public async Task<GetNumberOfEntriesResult> GetNumberOfEntriesAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetNumberOfEntries", null);
            return new GetNumberOfEntriesResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetCallList on service
        /// </summary>
        /// <returns>the result of the action GetCallList</returns>
        public async Task<GetCallListResult> GetCallListAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetCallList", null);
            return new GetCallListResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetPhonebookList on service
        /// </summary>
        /// <returns>the result of the action GetPhonebookList</returns>
        public async Task<GetPhonebookListResult> GetPhonebookListAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetPhonebookList", null);
            return new GetPhonebookListResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetPhonebook on service
        /// </summary>
        /// <param name="request">the request for the action GetPhonebook</param>
        /// <returns>the result of the action GetPhonebook</returns>
        public async Task<GetPhonebookResult> GetPhonebookAsync(GetPhonebookRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPhonebookID", request.PhonebookID.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetPhonebook", parameters.ToArray());
            return new GetPhonebookResult(soapResult);
        }

        /// <summary>
        /// method to invoke AddPhonebook on service
        /// </summary>
        /// <param name="request">the request for the action AddPhonebook</param>
        public async Task AddPhonebookAsync(AddPhonebookRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPhonebookExtraID", request.PhonebookExtraID.ToString()),
                new SOAP.SoapRequestParameter("NewPhonebookName", request.PhonebookName.ToString())
            };
            await base.InvokeAsync("AddPhonebook", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke DeletePhonebook on service
        /// </summary>
        /// <param name="request">the request for the action DeletePhonebook</param>
        public async Task DeletePhonebookAsync(DeletePhonebookRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPhonebookID", request.PhonebookID.ToString()),
                new SOAP.SoapRequestParameter("NewPhonebookExtraID", request.PhonebookExtraID.ToString())
            };
            await base.InvokeAsync("DeletePhonebook", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetPhonebookEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetPhonebookEntry</param>
        /// <returns>the result of the action GetPhonebookEntry</returns>
        public async Task<GetPhonebookEntryResult> GetPhonebookEntryAsync(GetPhonebookEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPhonebookID", request.PhonebookID.ToString()),
                new SOAP.SoapRequestParameter("NewPhonebookEntryID", request.PhonebookEntryID.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetPhonebookEntry", parameters.ToArray());
            return new GetPhonebookEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetPhonebookEntry on service
        /// </summary>
        /// <param name="request">the request for the action SetPhonebookEntry</param>
        public async Task SetPhonebookEntryAsync(SetPhonebookEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPhonebookID", request.PhonebookID.ToString()),
                new SOAP.SoapRequestParameter("NewPhonebookEntryID", request.PhonebookEntryID.ToString()),
                new SOAP.SoapRequestParameter("NewPhonebookEntryData", request.PhonebookEntryData.ToString())
            };
            await base.InvokeAsync("SetPhonebookEntry", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke DeletePhonebookEntry on service
        /// </summary>
        /// <param name="request">the request for the action DeletePhonebookEntry</param>
        public async Task DeletePhonebookEntryAsync(DeletePhonebookEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewPhonebookID", request.PhonebookID.ToString()),
                new SOAP.SoapRequestParameter("NewPhonebookEntryID", request.PhonebookEntryID.ToString())
            };
            await base.InvokeAsync("DeletePhonebookEntry", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetDECTHandsetList on service
        /// </summary>
        /// <returns>the result of the action GetDECTHandsetList</returns>
        public async Task<GetDECTHandsetListResult> GetDECTHandsetListAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetDECTHandsetList", null);
            return new GetDECTHandsetListResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetDECTHandsetInfo on service
        /// </summary>
        /// <param name="request">the request for the action GetDECTHandsetInfo</param>
        /// <returns>the result of the action GetDECTHandsetInfo</returns>
        public async Task<GetDECTHandsetInfoResult> GetDECTHandsetInfoAsync(GetDECTHandsetInfoRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewDectID", request.DectID.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetDECTHandsetInfo", parameters.ToArray());
            return new GetDECTHandsetInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetDECTHandsetPhonebook on service
        /// </summary>
        /// <param name="request">the request for the action SetDECTHandsetPhonebook</param>
        public async Task SetDECTHandsetPhonebookAsync(SetDECTHandsetPhonebookRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewDectID", request.DectID.ToString()),
                new SOAP.SoapRequestParameter("NewPhonebookID", request.PhonebookID.ToString())
            };
            await base.InvokeAsync("SetDECTHandsetPhonebook", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetNumberOfDeflections on service
        /// </summary>
        /// <returns>the result of the action GetNumberOfDeflections</returns>
        public async Task<GetNumberOfDeflectionsResult> GetNumberOfDeflectionsAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetNumberOfDeflections", null);
            return new GetNumberOfDeflectionsResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetDeflection on service
        /// </summary>
        /// <param name="request">the request for the action GetDeflection</param>
        /// <returns>the result of the action GetDeflection</returns>
        public async Task<GetDeflectionResult> GetDeflectionAsync(GetDeflectionRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewDeflectionId", request.DeflectionId.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetDeflection", parameters.ToArray());
            return new GetDeflectionResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetDeflections on service
        /// </summary>
        /// <returns>the result of the action GetDeflections</returns>
        public async Task<GetDeflectionsResult> GetDeflectionsAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetDeflections", null);
            return new GetDeflectionsResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetDeflectionEnable on service
        /// </summary>
        /// <param name="request">the request for the action SetDeflectionEnable</param>
        public async Task SetDeflectionEnableAsync(SetDeflectionEnableRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewDeflectionId", request.DeflectionId.ToString()),
                new SOAP.SoapRequestParameter("NewEnable", request.Enable ? "1" : "0")
            };
            await base.InvokeAsync("SetDeflectionEnable", parameters.ToArray());
        }

        #endregion
    }
}