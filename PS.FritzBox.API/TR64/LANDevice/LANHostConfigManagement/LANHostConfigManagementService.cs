using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.LANHostConfigManagement
{
    /// <summary>
    /// client proxy class for LANHostConfigManagement service
    /// </summary>
    public class LANHostConfigManagementService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for LANHostConfigManagementService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public LANHostConfigManagementService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for LANHostConfigManagementService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public LANHostConfigManagementService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for LANHostConfigManagementService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public LANHostConfigManagementService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for LANHostConfigManagementService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public LANHostConfigManagementService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/lanhostconfigmgm";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:LANHostConfigManagement:1";
		
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
        /// method to invoke SetDHCPServerEnable on service
        /// </summary>
        /// <param name="request">the request for the action SetDHCPServerEnable</param>
        public async Task SetDHCPServerEnableAsync(SetDHCPServerEnableRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewDHCPServerEnable", request.DHCPServerEnable ? "1" : "0")
            };
            await base.InvokeAsync("SetDHCPServerEnable", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetIPInterface on service
        /// </summary>
        /// <param name="request">the request for the action SetIPInterface</param>
        public async Task SetIPInterfaceAsync(SetIPInterfaceRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewEnable", request.Enable ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewIPAddress", request.IPAddress.ToString()),
                new SOAP.SoapRequestParameter("NewSubnetMask", request.SubnetMask.ToString()),
                new SOAP.SoapRequestParameter("NewIPAddressingType", request.IPAddressingType.ToString())
            };
            await base.InvokeAsync("SetIPInterface", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetAddressRange on service
        /// </summary>
        /// <returns>the result of the action GetAddressRange</returns>
        public async Task<GetAddressRangeResult> GetAddressRangeAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetAddressRange", null);
            return new GetAddressRangeResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetAddressRange on service
        /// </summary>
        /// <param name="request">the request for the action SetAddressRange</param>
        public async Task SetAddressRangeAsync(SetAddressRangeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewMinAddress", request.MinAddress.ToString()),
                new SOAP.SoapRequestParameter("NewMaxAddress", request.MaxAddress.ToString())
            };
            await base.InvokeAsync("SetAddressRange", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetIPRoutersList on service
        /// </summary>
        /// <returns>the result of the action GetIPRoutersList</returns>
        public async Task<GetIPRoutersListResult> GetIPRoutersListAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetIPRoutersList", null);
            return new GetIPRoutersListResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetIPRouter on service
        /// </summary>
        /// <param name="request">the request for the action SetIPRouter</param>
        public async Task SetIPRouterAsync(SetIPRouterRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewIPRouters", request.IPRouters.ToString())
            };
            await base.InvokeAsync("SetIPRouter", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetSubnetMask on service
        /// </summary>
        /// <returns>the result of the action GetSubnetMask</returns>
        public async Task<GetSubnetMaskResult> GetSubnetMaskAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetSubnetMask", null);
            return new GetSubnetMaskResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetSubnetMask on service
        /// </summary>
        /// <param name="request">the request for the action SetSubnetMask</param>
        public async Task SetSubnetMaskAsync(SetSubnetMaskRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewSubnetMask", request.SubnetMask.ToString())
            };
            await base.InvokeAsync("SetSubnetMask", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetDNSServers on service
        /// </summary>
        /// <returns>the result of the action GetDNSServers</returns>
        public async Task<GetDNSServersResult> GetDNSServersAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetDNSServers", null);
            return new GetDNSServersResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetIPInterfaceNumberOfEntries on service
        /// </summary>
        /// <returns>the result of the action GetIPInterfaceNumberOfEntries</returns>
        public async Task<GetIPInterfaceNumberOfEntriesResult> GetIPInterfaceNumberOfEntriesAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetIPInterfaceNumberOfEntries", null);
            return new GetIPInterfaceNumberOfEntriesResult(soapResult);
        }

        #endregion
    }
}