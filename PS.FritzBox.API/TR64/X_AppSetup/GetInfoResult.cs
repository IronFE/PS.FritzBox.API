using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_AppSetup
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
            this.MinCharsAppId = Convert.ToInt32(soapresult.Descendants("NewMinCharsAppId").First().Value);
            this.MaxCharsAppId = Convert.ToInt32(soapresult.Descendants("NewMaxCharsAppId").First().Value);
            this.AllowedCharsAppId = soapresult.Descendants("NewAllowedCharsAppId").First().Value;
            this.MinCharsAppDisplayName = Convert.ToInt32(soapresult.Descendants("NewMinCharsAppDisplayName").First().Value);
            this.MaxCharsAppDisplayName = Convert.ToInt32(soapresult.Descendants("NewMaxCharsAppDisplayName").First().Value);
            this.MinCharsAppUsername = Convert.ToInt32(soapresult.Descendants("NewMinCharsAppUsername").First().Value);
            this.MaxCharsAppUsername = Convert.ToInt32(soapresult.Descendants("NewMaxCharsAppUsername").First().Value);
            this.AllowedCharsAppUsername = soapresult.Descendants("NewAllowedCharsAppUsername").First().Value;
            this.MinCharsAppPassword = Convert.ToInt32(soapresult.Descendants("NewMinCharsAppPassword").First().Value);
            this.MaxCharsAppPassword = Convert.ToInt32(soapresult.Descendants("NewMaxCharsAppPassword").First().Value);
            this.AllowedCharsAppPassword = soapresult.Descendants("NewAllowedCharsAppPassword").First().Value;
            this.MinCharsIPSecIdentifier = Convert.ToInt32(soapresult.Descendants("NewMinCharsIPSecIdentifier").First().Value);
            this.MaxCharsIPSecIdentifier = Convert.ToInt32(soapresult.Descendants("NewMaxCharsIPSecIdentifier").First().Value);
            this.AllowedCharsIPSecIdentifier = soapresult.Descendants("NewAllowedCharsIPSecIdentifier").First().Value;
            this.AllowedCharsCryptAlgos = soapresult.Descendants("NewAllowedCharsCryptAlgos").First().Value;
            this.AllowedCharsAppAVMAddress = soapresult.Descendants("NewAllowedCharsAppAVMAddress").First().Value;
            this.MinCharsIPSecPreSharedKey = Convert.ToInt32(soapresult.Descendants("NewMinCharsIPSecPreSharedKey").First().Value);
            this.MaxCharsIPSecPreSharedKey = Convert.ToInt32(soapresult.Descendants("NewMaxCharsIPSecPreSharedKey").First().Value);
            this.AllowedCharsIPSecPreSharedKey = soapresult.Descendants("NewAllowedCharsIPSecPreSharedKey").First().Value;
            this.MinCharsIPSecXauthUsername = Convert.ToInt32(soapresult.Descendants("NewMinCharsIPSecXauthUsername").First().Value);
            this.MaxCharsIPSecXauthUsername = Convert.ToInt32(soapresult.Descendants("NewMaxCharsIPSecXauthUsername").First().Value);
            this.AllowedCharsIPSecXauthUsername = soapresult.Descendants("NewAllowedCharsIPSecXauthUsername").First().Value;
            this.MinCharsIPSecXauthPassword = Convert.ToInt32(soapresult.Descendants("NewMinCharsIPSecXauthPassword").First().Value);
            this.MaxCharsIPSecXauthPassword = Convert.ToInt32(soapresult.Descendants("NewMaxCharsIPSecXauthPassword").First().Value);
            this.AllowedCharsIPSecXauthPassword = soapresult.Descendants("NewAllowedCharsIPSecXauthPassword").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the MinCharsAppId
        /// </summary>
        public Int32 MinCharsAppId { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsAppId
        /// </summary>
        public Int32 MaxCharsAppId { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsAppId
        /// </summary>
        public string AllowedCharsAppId { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsAppDisplayName
        /// </summary>
        public Int32 MinCharsAppDisplayName { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsAppDisplayName
        /// </summary>
        public Int32 MaxCharsAppDisplayName { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsAppUsername
        /// </summary>
        public Int32 MinCharsAppUsername { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsAppUsername
        /// </summary>
        public Int32 MaxCharsAppUsername { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsAppUsername
        /// </summary>
        public string AllowedCharsAppUsername { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsAppPassword
        /// </summary>
        public Int32 MinCharsAppPassword { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsAppPassword
        /// </summary>
        public Int32 MaxCharsAppPassword { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsAppPassword
        /// </summary>
        public string AllowedCharsAppPassword { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsIPSecIdentifier
        /// </summary>
        public Int32 MinCharsIPSecIdentifier { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsIPSecIdentifier
        /// </summary>
        public Int32 MaxCharsIPSecIdentifier { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsIPSecIdentifier
        /// </summary>
        public string AllowedCharsIPSecIdentifier { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsCryptAlgos
        /// </summary>
        public string AllowedCharsCryptAlgos { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsAppAVMAddress
        /// </summary>
        public string AllowedCharsAppAVMAddress { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsIPSecPreSharedKey
        /// </summary>
        public Int32 MinCharsIPSecPreSharedKey { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsIPSecPreSharedKey
        /// </summary>
        public Int32 MaxCharsIPSecPreSharedKey { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsIPSecPreSharedKey
        /// </summary>
        public string AllowedCharsIPSecPreSharedKey { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsIPSecXauthUsername
        /// </summary>
        public Int32 MinCharsIPSecXauthUsername { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsIPSecXauthUsername
        /// </summary>
        public Int32 MaxCharsIPSecXauthUsername { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsIPSecXauthUsername
        /// </summary>
        public string AllowedCharsIPSecXauthUsername { get; internal set;}

        /// <summary>
        /// gets or sets the MinCharsIPSecXauthPassword
        /// </summary>
        public Int32 MinCharsIPSecXauthPassword { get; internal set;}

        /// <summary>
        /// gets or sets the MaxCharsIPSecXauthPassword
        /// </summary>
        public Int32 MaxCharsIPSecXauthPassword { get; internal set;}

        /// <summary>
        /// gets or sets the AllowedCharsIPSecXauthPassword
        /// </summary>
        public string AllowedCharsIPSecXauthPassword { get; internal set;}

        #endregion
    }
}