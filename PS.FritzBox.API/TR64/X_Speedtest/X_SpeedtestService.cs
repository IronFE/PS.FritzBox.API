using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Speedtest
{
    /// <summary>
    /// client proxy class for X_Speedtest service
    /// </summary>
    public class X_SpeedtestService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for X_SpeedtestService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public X_SpeedtestService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for X_SpeedtestService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public X_SpeedtestService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for X_SpeedtestService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public X_SpeedtestService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for X_SpeedtestService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public X_SpeedtestService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/x_speedtest";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:X_AVM-DE_Speedtest:1";
		
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
        /// method to invoke SetConfig on service
        /// </summary>
        /// <param name="request">the request for the action SetConfig</param>
        public async Task SetConfigAsync(SetConfigRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewEnableTcp", request.EnableTcp ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewEnableUdp", request.EnableUdp ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewEnableUdpBidirect", request.EnableUdpBidirect ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewWANEnableTcp", request.WANEnableTcp ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewWANEnableUdp", request.WANEnableUdp ? "1" : "0")
            };
            await base.InvokeAsync("SetConfig", parameters.ToArray());
        }

        #endregion
    }
}