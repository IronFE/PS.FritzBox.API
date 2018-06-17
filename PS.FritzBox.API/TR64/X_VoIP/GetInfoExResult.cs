using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for GetInfoEx
    /// </summary>
    public class GetInfoExResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetInfoExResult(XDocument soapresult)
        {
            this.VoIPNumberMinChars = Convert.ToInt32(soapresult.Descendants("NewVoIPNumberMinChars").First().Value);
            this.VoIPNumberMaxChars = Convert.ToInt32(soapresult.Descendants("NewVoIPNumberMaxChars").First().Value);
            this.VoIPNumberAllowedChars = soapresult.Descendants("NewVoIPNumberAllowedChars").First().Value;
            this.VoIPUsernameMinChars = Convert.ToInt32(soapresult.Descendants("NewVoIPUsernameMinChars").First().Value);
            this.VoIPUsernameMaxChars = Convert.ToInt32(soapresult.Descendants("NewVoIPUsernameMaxChars").First().Value);
            this.VoIPUsernameAllowedChars = soapresult.Descendants("NewVoIPUsernameAllowedChars").First().Value;
            this.VoIPPasswordMinChars = Convert.ToInt32(soapresult.Descendants("NewVoIPPasswordMinChars").First().Value);
            this.VoIPPasswordMaxChars = Convert.ToInt32(soapresult.Descendants("NewVoIPPasswordMaxChars").First().Value);
            this.VoIPPasswordAllowedChars = soapresult.Descendants("NewVoIPPasswordAllowedChars").First().Value;
            this.VoIPRegistrarMinChars = Convert.ToInt32(soapresult.Descendants("NewVoIPRegistrarMinChars").First().Value);
            this.VoIPRegistrarMaxChars = Convert.ToInt32(soapresult.Descendants("NewVoIPRegistrarMaxChars").First().Value);
            this.VoIPRegistrarAllowedChars = soapresult.Descendants("NewVoIPRegistrarAllowedChars").First().Value;
            this.VoIPSTUNServerMinChars = Convert.ToInt32(soapresult.Descendants("NewVoIPSTUNServerMinChars").First().Value);
            this.VoIPSTUNServerMaxChars = Convert.ToInt32(soapresult.Descendants("NewVoIPSTUNServerMaxChars").First().Value);
            this.VoIPSTUNServerAllowedChars = soapresult.Descendants("NewVoIPSTUNServerAllowedChars").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the VoIPNumberMinChars
        /// </summary>
        public Int32 VoIPNumberMinChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPNumberMaxChars
        /// </summary>
        public Int32 VoIPNumberMaxChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPNumberAllowedChars
        /// </summary>
        public string VoIPNumberAllowedChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPUsernameMinChars
        /// </summary>
        public Int32 VoIPUsernameMinChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPUsernameMaxChars
        /// </summary>
        public Int32 VoIPUsernameMaxChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPUsernameAllowedChars
        /// </summary>
        public string VoIPUsernameAllowedChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPPasswordMinChars
        /// </summary>
        public Int32 VoIPPasswordMinChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPPasswordMaxChars
        /// </summary>
        public Int32 VoIPPasswordMaxChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPPasswordAllowedChars
        /// </summary>
        public string VoIPPasswordAllowedChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPRegistrarMinChars
        /// </summary>
        public Int32 VoIPRegistrarMinChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPRegistrarMaxChars
        /// </summary>
        public Int32 VoIPRegistrarMaxChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPRegistrarAllowedChars
        /// </summary>
        public string VoIPRegistrarAllowedChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPSTUNServerMinChars
        /// </summary>
        public Int32 VoIPSTUNServerMinChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPSTUNServerMaxChars
        /// </summary>
        public Int32 VoIPSTUNServerMaxChars { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPSTUNServerAllowedChars
        /// </summary>
        public string VoIPSTUNServerAllowedChars { get; internal set;}

        #endregion
    }
}