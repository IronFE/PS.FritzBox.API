using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for X_GetVoIPAccount
    /// </summary>
    public class X_GetVoIPAccountResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetVoIPAccountResult(XDocument soapresult)
        {
            this.VoIPRegistrar = soapresult.Descendants("NewVoIPRegistrar").First().Value;
            this.VoIPNumber = soapresult.Descendants("NewVoIPNumber").First().Value;
            this.VoIPUsername = soapresult.Descendants("NewVoIPUsername").First().Value;
            this.VoIPPassword = soapresult.Descendants("NewVoIPPassword").First().Value;
            this.VoIPOutboundProxy = soapresult.Descendants("NewVoIPOutboundProxy").First().Value;
            this.VoIPSTUNServer = soapresult.Descendants("NewVoIPSTUNServer").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the VoIPRegistrar
        /// </summary>
        public string VoIPRegistrar { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPNumber
        /// </summary>
        public string VoIPNumber { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPUsername
        /// </summary>
        public string VoIPUsername { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPPassword
        /// </summary>
        public string VoIPPassword { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPOutboundProxy
        /// </summary>
        public string VoIPOutboundProxy { get; internal set;}

        /// <summary>
        /// gets or sets the VoIPSTUNServer
        /// </summary>
        public string VoIPSTUNServer { get; internal set;}

        #endregion
    }
}