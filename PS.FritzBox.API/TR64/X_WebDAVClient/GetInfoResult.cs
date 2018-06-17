using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_WebDAVClient
{
    /// <summary>
    /// result object for GetInfo
    /// </summary>
    public class GetInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetInfoResult(XDocument soapresult)
        {
            this.Enable = soapresult.Descendants("NewEnable").First().Value == "1";
            this.HostURL = soapresult.Descendants("NewHostURL").First().Value;
            this.Username = soapresult.Descendants("NewUsername").First().Value;
            this.MountpointName = soapresult.Descendants("NewMountpointName").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; internal set;}

        /// <summary>
        /// gets or sets the HostURL
        /// </summary>
        public string HostURL { get; internal set;}

        /// <summary>
        /// gets or sets the Username
        /// </summary>
        public string Username { get; internal set;}

        /// <summary>
        /// gets or sets the MountpointName
        /// </summary>
        public string MountpointName { get; internal set;}

        #endregion
    }
}