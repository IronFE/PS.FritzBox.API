using PS.FritzBox.API.WANDevice.WANConnectionDevice;
using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for GetInfo
    /// </summary>
    public class GetWANPPPConnectionInfoRequest : GetWANConnectionInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetWANPPPConnectionInfoRequest(XDocument soapresult) : base(soapresult)
        {             
            this.UpstreamMaxBitRate = Convert.ToInt32(soapresult.Descendants("NewUpstreamMaxBitRate").First().Value);
            this.DownstreamMaxBitRate = Convert.ToInt32(soapresult.Descendants("NewDownstreamMaxBitRate").First().Value);
            this.IdleDisconnectTime = Convert.ToInt32(soapresult.Descendants("NewIdleDisconnectTime").First().Value);           
            this.UserName = soapresult.Descendants("NewUserName").First().Value;           
            this.LastAuthErrorInfo = soapresult.Descendants("NewLastAuthErrorInfo").First().Value;           
            this.MaxCharsUsername = Convert.ToInt32(soapresult.Descendants("NewMaxCharsUsername").First().Value);
            this.MinCharsUsername = Convert.ToInt32(soapresult.Descendants("NewMinCharsUsername").First().Value);
            this.AllowedCharsUsername = soapresult.Descendants("NewAllowedCharsUsername").First().Value;           
            this.MaxCharsPassword = Convert.ToInt32(soapresult.Descendants("NewMaxCharsPassword").First().Value);
            this.MinCharsPassword = Convert.ToInt32(soapresult.Descendants("NewMinCharsPassword").First().Value);           
            this.AllowedCharsPassword = soapresult.Descendants("NewAllowedCharsPassword").First().Value;         
            this.TransportType = soapresult.Descendants("NewTransportType").First().Value;            
            this.PPPoEServiceName = soapresult.Descendants("NewPPPoEServiceName").First().Value;            
            this.RemoteIPAddress = soapresult.Descendants("NewRemoteIPAddress").First().Value;            
            this.PPPoEACName = soapresult.Descendants("NewPPPoEACName").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the UpstreamMaxBitRate
        /// </summary>
        public Int32 UpstreamMaxBitRate { get; internal set;}

        /// <summary>
        /// gets or sets the DownstreamMaxBitRate
        /// </summary>
        public Int32 DownstreamMaxBitRate { get; internal set;}

        /// <summary>
        /// gets or sets the IdleDisconnectTime
        /// </summary>
        public Int32 IdleDisconnectTime { get; internal set;}

        /// <summary>
        /// gets or sets the UserName
        /// </summary>
        public string UserName { get; internal set;}

        /// <summary>
        /// gets or sets the LastAuthErrorInfo
        /// </summary>
        public string LastAuthErrorInfo { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsUsername
        /// </summary>
        public Int32 MaxCharsUsername { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsUsername
        /// </summary>
        public Int32 MinCharsUsername { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsUsername
        /// </summary>
        public string AllowedCharsUsername { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsPassword
        /// </summary>
        public Int32 MaxCharsPassword { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsPassword
        /// </summary>
        public Int32 MinCharsPassword { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsPassword
        /// </summary>
        public string AllowedCharsPassword { get; internal set;}

        /// <summary>
        /// gets or sets the TransportType
        /// </summary>
        public string TransportType { get; internal set;}

        /// <summary>
        /// gets or sets the PPPoEServiceName
        /// </summary>
        public string PPPoEServiceName { get; internal set;}

        /// <summary>
        /// gets or sets the RemoteIPAddress
        /// </summary>
        public string RemoteIPAddress { get; internal set;}

        /// <summary>
        /// gets or sets the PPPoEACName
        /// </summary>
        public string PPPoEACName { get; internal set;}

        #endregion
    }
}