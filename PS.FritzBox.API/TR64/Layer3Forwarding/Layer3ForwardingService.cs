using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64
{
    /// <summary>
    /// client proxy class for Layer3Forwarding service
    /// </summary>
    public class Layer3ForwardingService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for Layer3ForwardingService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public Layer3ForwardingService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for Layer3ForwardingService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public Layer3ForwardingService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for Layer3ForwardingService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public Layer3ForwardingService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for Layer3ForwardingService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public Layer3ForwardingService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/layer3forwarding";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:Layer3Forwarding:1";

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke SetDefaultConnectionService on service
        /// </summary>
        /// <param name="request">the request for the action SetDefaultConnectionService</param>
        public async Task SetDefaultConnectionServiceAsync(SetDefaultConnectionServiceRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewDefaultConnectionService", request.DefaultConnectionService.ToString())
            };
            await base.InvokeAsync("SetDefaultConnectionService", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetDefaultConnectionService on service
        /// </summary>
        /// <returns>the result of the action GetDefaultConnectionService</returns>
        public async Task<GetDefaultConnectionServiceResult> GetDefaultConnectionServiceAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetDefaultConnectionService", null);
            return new GetDefaultConnectionServiceResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetForwardNumberOfEntries on service
        /// </summary>
        /// <returns>the result of the action GetForwardNumberOfEntries</returns>
        public async Task<GetForwardNumberOfEntriesResult> GetForwardNumberOfEntriesAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetForwardNumberOfEntries", null);
            return new GetForwardNumberOfEntriesResult(soapResult);
        }

        /// <summary>
        /// method to invoke AddForwardingEntry on service
        /// </summary>
        /// <param name="request">the request for the action AddForwardingEntry</param>
        public async Task AddForwardingEntryAsync(AddForwardingEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewType", request.Type.ToString()),
                new SOAP.SoapRequestParameter("NewDestIPAddress", request.DestIPAddress.ToString()),
                new SOAP.SoapRequestParameter("NewDestSubnetMask", request.DestSubnetMask.ToString()),
                new SOAP.SoapRequestParameter("NewSourceIPAddress", request.SourceIPAddress.ToString()),
                new SOAP.SoapRequestParameter("NewSourceSubnetMask", request.SourceSubnetMask.ToString()),
                new SOAP.SoapRequestParameter("NewGatewayIPAddress", request.GatewayIPAddress.ToString()),
                new SOAP.SoapRequestParameter("NewInterface", request.Interface.ToString()),
                new SOAP.SoapRequestParameter("NewForwardingMetric", request.ForwardingMetric.ToString())
            };
            await base.InvokeAsync("AddForwardingEntry", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke DeleteForwardingEntry on service
        /// </summary>
        /// <param name="request">the request for the action DeleteForwardingEntry</param>
        public async Task DeleteForwardingEntryAsync(DeleteForwardingEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewDestIPAddress", request.DestIPAddress.ToString()),
                new SOAP.SoapRequestParameter("NewDestSubnetMask", request.DestSubnetMask.ToString()),
                new SOAP.SoapRequestParameter("NewSourceIPAddress", request.SourceIPAddress.ToString()),
                new SOAP.SoapRequestParameter("NewSourceSubnetMask", request.SourceSubnetMask.ToString())
            };
            await base.InvokeAsync("DeleteForwardingEntry", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetSpecificForwardingEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetSpecificForwardingEntry</param>
        /// <returns>the result of the action GetSpecificForwardingEntry</returns>
        public async Task<GetSpecificForwardingEntryResult> GetSpecificForwardingEntryAsync(GetSpecificForwardingEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewDestIPAddress", request.DestIPAddress.ToString()),
                new SOAP.SoapRequestParameter("NewDestSubnetMask", request.DestSubnetMask.ToString()),
                new SOAP.SoapRequestParameter("NewSourceIPAddress", request.SourceIPAddress.ToString()),
                new SOAP.SoapRequestParameter("NewSourceSubnetMask", request.SourceSubnetMask.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetSpecificForwardingEntry", parameters.ToArray());
            return new GetSpecificForwardingEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetGenericForwardingEntry on service
        /// </summary>
        /// <param name="request">the request for the action GetGenericForwardingEntry</param>
        /// <returns>the result of the action GetGenericForwardingEntry</returns>
        public async Task<GetGenericForwardingEntryResult> GetGenericForwardingEntryAsync(GetGenericForwardingEntryRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewForwardingIndex", request.ForwardingIndex.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetGenericForwardingEntry", parameters.ToArray());
            return new GetGenericForwardingEntryResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetForwardingEntryEnable on service
        /// </summary>
        /// <param name="request">the request for the action SetForwardingEntryEnable</param>
        public async Task SetForwardingEntryEnableAsync(SetForwardingEntryEnableRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewDestIPAddress", request.DestIPAddress.ToString()),
                new SOAP.SoapRequestParameter("NewDestSubnetMask", request.DestSubnetMask.ToString()),
                new SOAP.SoapRequestParameter("NewSourceIPAddress", request.SourceIPAddress.ToString()),
                new SOAP.SoapRequestParameter("NewSourceSubnetMask", request.SourceSubnetMask.ToString()),
                new SOAP.SoapRequestParameter("NewEnable", request.Enable ? "1" : "0")
            };
            await base.InvokeAsync("SetForwardingEntryEnable", parameters.ToArray());
        }

        #endregion
    }
}