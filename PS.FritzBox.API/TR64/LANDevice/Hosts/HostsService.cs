using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.Hosts
{
    /// <summary>
    /// client proxy class for Hosts service
    /// </summary>
    public class HostsService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for HostsService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public HostsService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for HostsService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public HostsService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for HostsService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public HostsService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for HostsService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public HostsService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/hosts";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:Hosts:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke GetHostNumberOfEntries on service
        /// </summary>
        /// <returns>the result of the action GetHostNumberOfEntries</returns>
        public async Task<GetHostNumberOfEntriesResult> GetHostNumberOfEntriesAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetHostNumberOfEntries", null);
            return new GetHostNumberOfEntriesResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetSpecificHostEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetSpecificHostEntry</param>
        /// <returns>the result of the action GetSpecificHostEntry</returns>
        public async Task<GetSpecificHostEntryResult> GetSpecificHostEntryAsync(GetSpecificHostEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewMACAddress", request.MACAddress.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetSpecificHostEntry", parameters.ToArray());
            return new GetSpecificHostEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetGenericHostEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetGenericHostEntry</param>
        /// <returns>the result of the action GetGenericHostEntry</returns>
        public async Task<GetGenericHostEntryResult> GetGenericHostEntryAsync(GetGenericHostEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetGenericHostEntry", parameters.ToArray());
            return new GetGenericHostEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetGenericHostEntryExt on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_GetGenericHostEntryExt</param>
        /// <returns>the result of the action X_AVM-DE_GetGenericHostEntryExt</returns>
        public async Task<X_GetGenericHostEntryExtResult> X_GetGenericHostEntryExtAsync(X_GetGenericHostEntryExtRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIndex", request.Index.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetGenericHostEntryExt", parameters.ToArray());
            return new X_GetGenericHostEntryExtResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetChangeCounter on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetChangeCounter</returns>
        public async Task<X_GetChangeCounterResult> X_GetChangeCounterAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetChangeCounter", null);
            return new X_GetChangeCounterResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetHostNameByMACAddress on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetHostNameByMACAddress</param>
        public async Task X_SetHostNameByMACAddressAsync(X_SetHostNameByMACAddressRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewMACAddress", request.MACAddress.ToString()),
                new SOAP.SoapRequestParameter("NewHostName", request.HostName.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_SetHostNameByMACAddress", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetAutoWakeOnLANByMACAddress on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_GetAutoWakeOnLANByMACAddress</param>
        /// <returns>the result of the action X_AVM-DE_GetAutoWakeOnLANByMACAddress</returns>
        public async Task<X_GetAutoWakeOnLANByMACAddressResult> X_GetAutoWakeOnLANByMACAddressAsync(X_GetAutoWakeOnLANByMACAddressRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewMACAddress", request.MACAddress.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetAutoWakeOnLANByMACAddress", parameters.ToArray());
            return new X_GetAutoWakeOnLANByMACAddressResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetAutoWakeOnLANByMACAddress on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetAutoWakeOnLANByMACAddress</param>
        public async Task X_SetAutoWakeOnLANByMACAddressAsync(X_SetAutoWakeOnLANByMACAddressRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewMACAddress", request.MACAddress.ToString()),
                new SOAP.SoapRequestParameter("NewAutoWOLEnabled", request.AutoWOLEnabled ? "1" : "0")
            };
            await base.InvokeAsync("X_AVM-DE_SetAutoWakeOnLANByMACAddress", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_WakeOnLANByMACAddress on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_WakeOnLANByMACAddress</param>
        public async Task X_WakeOnLANByMACAddressAsync(X_WakeOnLANByMACAddressRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewMACAddress", request.MACAddress.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_WakeOnLANByMACAddress", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetSpecificHostEntryExt on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_GetSpecificHostEntryExt</param>
        /// <returns>the result of the action X_AVM-DE_GetSpecificHostEntryExt</returns>
        public async Task<X_GetSpecificHostEntryExtResult> X_GetSpecificHostEntryExtAsync(X_GetSpecificHostEntryExtRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewMACAddress", request.MACAddress.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetSpecificHostEntryExt", parameters.ToArray());
            return new X_GetSpecificHostEntryExtResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_HostsCheckUpdate on service
        /// </summary>
        public async Task X_HostsCheckUpdate()
        {
            await base.InvokeAsync("X_AVM-DE_HostsCheckUpdate", null);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_HostDoUpdate on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_HostDoUpdate</param>
        public async Task X_HostDoUpdateAsync(X_HostDoUpdateRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewMACAddress", request.MACAddress.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_HostDoUpdate", parameters.ToArray());
        }

        #endregion
    }
}