using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Homeplug
{
    /// <summary>
    /// client proxy class for X_Homeplug service
    /// </summary>
    public class X_HomeplugService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for X_HomeplugService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public X_HomeplugService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for X_HomeplugService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public X_HomeplugService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for X_HomeplugService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public X_HomeplugService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for X_HomeplugService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public X_HomeplugService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/x_homeplug";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:X_AVM-DE_Homeplug:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke GetNumberOfDeviceEntries on service
        /// </summary>
        /// <returns>the result of the action GetNumberOfDeviceEntries</returns>
        public async Task<GetNumberOfDeviceEntriesResult> GetNumberOfDeviceEntriesAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetNumberOfDeviceEntries", null);
            return new GetNumberOfDeviceEntriesResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetGenericDeviceEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetGenericDeviceEntry</param>
        /// <returns>the result of the action GetGenericDeviceEntry</returns>
        public async Task<GetGenericDeviceEntryResult> GetGenericDeviceEntryAsync(GetGenericDeviceEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetGenericDeviceEntry", parameters.ToArray());
            return new GetGenericDeviceEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetSpecificDeviceEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetSpecificDeviceEntry</param>
        /// <returns>the result of the action GetSpecificDeviceEntry</returns>
        public async Task<GetSpecificDeviceEntryResult> GetSpecificDeviceEntryAsync(GetSpecificDeviceEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewMACAddress", request.MACAddress.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetSpecificDeviceEntry", parameters.ToArray());
            return new GetSpecificDeviceEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke DeviceDoUpdate on service
        /// </summary>
        /// <param name="request">the request for the action DeviceDoUpdate</param>
        public async Task DeviceDoUpdateAsync(DeviceDoUpdateRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewMACAddress", request.MACAddress.ToString())
            };
            await base.InvokeAsync("DeviceDoUpdate", parameters.ToArray());
        }

        #endregion
    }
}