using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// client proxy class for X_VoIP service
    /// </summary>
    public class X_VoIPService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for X_VoIPService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public X_VoIPService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for X_VoIPService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public X_VoIPService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for X_VoIPService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public X_VoIPService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for X_VoIPService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public X_VoIPService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/x_voip";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:X_VoIP:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke GetInfoEx on service
        /// </summary>
        /// <returns>the result of the action GetInfoEx</returns>
        public async Task<GetInfoExResult> GetInfoExAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetInfoEx", null);
            return new GetInfoExResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_AddVoIPAccount on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_AddVoIPAccount</param>
        public async Task X_AddVoIPAccountAsync(X_AddVoIPAccountRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewVoIPAccountIndex", request.VoIPAccountIndex.ToString()),
                new SOAP.SoapRequestParameter("NewVoIPRegistrar", request.VoIPRegistrar.ToString()),
                new SOAP.SoapRequestParameter("NewVoIPNumber", request.VoIPNumber.ToString()),
                new SOAP.SoapRequestParameter("NewVoIPUsername", request.VoIPUsername.ToString()),
                new SOAP.SoapRequestParameter("NewVoIPPassword", request.VoIPPassword.ToString()),
                new SOAP.SoapRequestParameter("NewVoIPOutboundProxy", request.VoIPOutboundProxy.ToString()),
                new SOAP.SoapRequestParameter("NewVoIPSTUNServer", request.VoIPSTUNServer.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_AddVoIPAccount", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetVoIPAccount on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_GetVoIPAccount</param>
        /// <returns>the result of the action X_AVM-DE_GetVoIPAccount</returns>
        public async Task<X_GetVoIPAccountResult> X_GetVoIPAccountAsync(X_GetVoIPAccountRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewVoIPAccountIndex", request.VoIPAccountIndex.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetVoIPAccount", parameters.ToArray());
            return new X_GetVoIPAccountResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_DelVoIPAccount on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_DelVoIPAccount</param>
        public async Task X_DelVoIPAccountAsync(X_DelVoIPAccountRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewVoIPAccountIndex", request.VoIPAccountIndex.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_DelVoIPAccount", parameters.ToArray());
        }

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
        /// method to invoke SetConfig on service
        /// </summary>
        /// <param name="request">the request for the action SetConfig</param>
        public async Task SetConfigAsync(SetConfigRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewFaxT38Enable", request.FaxT38Enable ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewVoiceCoding", request.VoiceCoding.ToString())
            };
            await base.InvokeAsync("SetConfig", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetMaxVoIPNumbers on service
        /// </summary>
        /// <returns>the result of the action GetMaxVoIPNumbers</returns>
        public async Task<GetMaxVoIPNumbersResult> GetMaxVoIPNumbersAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetMaxVoIPNumbers", null);
            return new GetMaxVoIPNumbersResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetExistingVoIPNumbers on service
        /// </summary>
        /// <returns>the result of the action GetExistingVoIPNumbers</returns>
        public async Task<GetExistingVoIPNumbersResult> GetExistingVoIPNumbersAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetExistingVoIPNumbers", null);
            return new GetExistingVoIPNumbersResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetNumberOfClients on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetNumberOfClients</returns>
        public async Task<X_GetNumberOfClientsResult> X_GetNumberOfClientsAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetNumberOfClients", null);
            return new X_GetNumberOfClientsResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetClient on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_GetClient</param>
        /// <returns>the result of the action X_AVM-DE_GetClient</returns>
        public async Task<X_GetClientResult> X_GetClientAsync(X_GetClientRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ClientIndex", request.ClientIndex.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetClient", parameters.ToArray());
            return new X_GetClientResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetClient2 on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_GetClient2</param>
        /// <returns>the result of the action X_AVM-DE_GetClient2</returns>
        public async Task<X_GetClient2Result> X_GetClient2Async(X_GetClientRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ClientIndex", request.ClientIndex.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetClient2", parameters.ToArray());
            return new X_GetClient2Result(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetClient on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetClient</param>
        public async Task X_SetClientAsync(X_SetClientRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ClientIndex", request.ClientIndex.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ClientPassword", request.ClientPassword.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_PhoneName", request.PhoneName.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_OutGoingNumber", request.OutGoingNumber.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_SetClient", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetClient2 on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetClient2</param>
        public async Task X_SetClient2Async(X_SetClient2Request request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ClientIndex", request.ClientIndex.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ClientPassword", request.ClientPassword.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ClientId", request.ClientId.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_PhoneName", request.PhoneName.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_OutGoingNumber", request.OutGoingNumber.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_SetClient2", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetClient3 on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_GetClient3</param>
        /// <returns>the result of the action X_AVM-DE_GetClient3</returns>
        public async Task<X_GetClient3Result> X_GetClient3Async(X_GetClientRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ClientIndex", request.ClientIndex.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetClient3", parameters.ToArray());
            return new X_GetClient3Result(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetClient3 on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetClient3</param>
        public async Task X_SetClient3Async(X_SetClient3Request request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ClientIndex", request.ClientIndex.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ClientPassword", request.ClientPassword.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ClientId", request.ClientId.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_PhoneName", request.PhoneName.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_OutGoingNumber", request.OutGoingNumber.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_InComingNumbers", request.InComingNumbers.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ExternalRegistration", request.ExternalRegistration ? "1" : "0")
            };
            await base.InvokeAsync("X_AVM-DE_SetClient3", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetClients on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetClients</returns>
        public async Task<X_GetClientsResult> X_GetClientsAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetClients", null);
            return new X_GetClientsResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetNumberOfNumbers on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetNumberOfNumbers</returns>
        public async Task<X_GetNumberOfNumbersResult> X_GetNumberOfNumbersAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetNumberOfNumbers", null);
            return new X_GetNumberOfNumbersResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetNumbers on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetNumbers</returns>
        public async Task<X_GetNumbersResult> X_GetNumbersAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetNumbers", null);
            return new X_GetNumbersResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_DeleteClient on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_DeleteClient</param>
        public async Task X_DeleteClientAsync(X_DeleteClientRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_ClientIndex", request.ClientIndex.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_DeleteClient", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_DialGetConfig on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_DialGetConfig</returns>
        public async Task<X_DialGetConfigResult> X_DialGetConfigAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_DialGetConfig", null);
            return new X_DialGetConfigResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_DialSetConfig on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_DialSetConfig</param>
        public async Task X_DialSetConfigAsync(X_DialSetConfigRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_PhoneName", request.PhoneName.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_DialSetConfig", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_DialNumber on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_DialNumber</param>
        public async Task X_DialNumberAsync(X_DialNumberRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_PhoneNumber", request.PhoneNumber.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_DialNumber", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_DialHangup on service
        /// </summary>
        public async Task X_DialHangup()
        {
            await base.InvokeAsync("X_AVM-DE_DialHangup", null);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetPhonePort on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_GetPhonePort</param>
        /// <returns>the result of the action X_AVM-DE_GetPhonePort</returns>
        public async Task<X_GetPhonePortResult> X_GetPhonePortAsync(X_GetPhonePortRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetPhonePort", parameters.ToArray());
            return new X_GetPhonePortResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetVoIPCommonCountryCode on service
        /// </summary>
        /// <returns>the result of the action GetVoIPCommonCountryCode</returns>
        public async Task<GetVoIPCommonCountryCodeResult> GetVoIPCommonCountryCodeAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetVoIPCommonCountryCode", null);
            return new GetVoIPCommonCountryCodeResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetVoIPCommonCountryCode on service
        /// </summary>
        /// <param name="request">the request for the action SetVoIPCommonCountryCode</param>
        public async Task SetVoIPCommonCountryCodeAsync(SetVoIPCommonCountryCodeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewVoIPCountryCode", request.VoIPCountryCode.ToString())
            };
            await base.InvokeAsync("SetVoIPCommonCountryCode", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetVoIPEnableCountryCode on service
        /// </summary>
        /// <param name="request">the request for the action GetVoIPEnableCountryCode</param>
        /// <returns>the result of the action GetVoIPEnableCountryCode</returns>
        public async Task<GetVoIPEnableCountryCodeResult> GetVoIPEnableCountryCodeAsync(GetVoIPEnableCountryCodeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewVoIPAccountIndex", request.VoIPAccountIndex.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetVoIPEnableCountryCode", parameters.ToArray());
            return new GetVoIPEnableCountryCodeResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetVoIPEnableCountryCode on service
        /// </summary>
        /// <param name="request">the request for the action SetVoIPEnableCountryCode</param>
        public async Task SetVoIPEnableCountryCodeAsync(SetVoIPEnableCountryCodeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewVoIPAccountIndex", request.VoIPAccountIndex.ToString()),
                new SOAP.SoapRequestParameter("NewVoIPEnableCountryCode", request.VoIPEnableCountryCode ? "1" : "0")
            };
            await base.InvokeAsync("SetVoIPEnableCountryCode", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetVoIPCommonAreaCode on service
        /// </summary>
        /// <returns>the result of the action GetVoIPCommonAreaCode</returns>
        public async Task<GetVoIPCommonAreaCodeResult> GetVoIPCommonAreaCodeAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetVoIPCommonAreaCode", null);
            return new GetVoIPCommonAreaCodeResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetVoIPCommonAreaCode on service
        /// </summary>
        /// <param name="request">the request for the action SetVoIPCommonAreaCode</param>
        public async Task SetVoIPCommonAreaCodeAsync(SetVoIPCommonAreaCodeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewVoIPAreaCode", request.VoIPAreaCode.ToString())
            };
            await base.InvokeAsync("SetVoIPCommonAreaCode", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetVoIPEnableAreaCode on service
        /// </summary>
        /// <param name="request">the request for the action GetVoIPEnableAreaCode</param>
        /// <returns>the result of the action GetVoIPEnableAreaCode</returns>
        public async Task<GetVoIPEnableAreaCodeResult> GetVoIPEnableAreaCodeAsync(GetVoIPEnableAreaCodeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewVoIPAccountIndex", request.VoIPAccountIndex.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetVoIPEnableAreaCode", parameters.ToArray());
            return new GetVoIPEnableAreaCodeResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetVoIPEnableAreaCode on service
        /// </summary>
        /// <param name="request">the request for the action SetVoIPEnableAreaCode</param>
        public async Task SetVoIPEnableAreaCodeAsync(SetVoIPEnableAreaCodeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewVoIPAccountIndex", request.VoIPAccountIndex.ToString()),
                new SOAP.SoapRequestParameter("NewVoIPEnableAreaCode", request.VoIPEnableAreaCode ? "1" : "0")
            };
            await base.InvokeAsync("SetVoIPEnableAreaCode", parameters.ToArray());
        }

        #endregion
    }
}