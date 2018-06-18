using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.Time
{
    /// <summary>
    /// client proxy class for Time service
    /// </summary>
    public class TimeService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for TimeService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public TimeService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for TimeService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public TimeService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for TimeService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public TimeService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for TimeService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public TimeService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/time";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:Time:1";

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
        /// method to invoke SetNTPServers on service
        /// </summary>
        /// <param name="request">the request for the action SetNTPServers</param>
        public async Task SetNTPServersAsync(SetNTPServersRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewNTPServer1", request.NTPServer1.ToString()),
                new SOAP.SoapRequestParameter("NewNTPServer2", request.NTPServer2.ToString())
            };
            await base.InvokeAsync("SetNTPServers", parameters.ToArray());
        }

        #endregion
    }
}