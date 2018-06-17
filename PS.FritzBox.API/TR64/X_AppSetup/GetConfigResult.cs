using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_AppSetup
{
    /// <summary>
    /// result object for GetConfig
    /// </summary>
    public class GetConfigResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetConfigResult(XDocument soapresult)
        {
            this.ConfigRight = (ConfigRight)Enum.Parse(typeof(ConfigRight), soapresult.Descendants("NewConfigRight").First().Value);
            this.AppRight = (AppRight)Enum.Parse(typeof(AppRight), soapresult.Descendants("NewAppRight").First().Value);
            this.NasRight = (NasRight)Enum.Parse(typeof(NasRight), soapresult.Descendants("NewNasRight").First().Value);
            this.PhoneRight = (PhoneRight)Enum.Parse(typeof(PhoneRight), soapresult.Descendants("NewPhoneRight").First().Value);
            this.DialRight = (DialRight)Enum.Parse(typeof(DialRight), soapresult.Descendants("NewDialRight").First().Value);
            this.HomeautoRight = (HomeautoRight)Enum.Parse(typeof(HomeautoRight), soapresult.Descendants("NewHomeautoRight").First().Value);
            this.InternetRights = soapresult.Descendants("NewInternetRights").First().Value == "1";
            this.AccessFromInternet = soapresult.Descendants("NewAccessFromInternet").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ConfigRight
        /// </summary>
        public ConfigRight ConfigRight { get; internal set;}

        /// <summary>
        /// gets or sets the AppRight
        /// </summary>
        public AppRight AppRight { get; internal set;}

        /// <summary>
        /// gets or sets the NasRight
        /// </summary>
        public NasRight NasRight { get; internal set;}

        /// <summary>
        /// gets or sets the PhoneRight
        /// </summary>
        public PhoneRight PhoneRight { get; internal set;}

        /// <summary>
        /// gets or sets the DialRight
        /// </summary>
        public DialRight DialRight { get; internal set;}

        /// <summary>
        /// gets or sets the HomeautoRight
        /// </summary>
        public HomeautoRight HomeautoRight { get; internal set;}

        /// <summary>
        /// gets or sets the InternetRights
        /// </summary>
        public bool InternetRights { get; internal set;}

        /// <summary>
        /// gets or sets the AccessFromInternet
        /// </summary>
        public bool AccessFromInternet { get; internal set;}

        #endregion
    }
}