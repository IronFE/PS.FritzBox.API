using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for X_GetClient2
    /// </summary>
    public class X_GetClient2Result
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetClient2Result(XDocument soapresult)
        {
            this.ClientUsername = soapresult.Descendants("NewX_AVM-DE_ClientUsername").First().Value;
            this.ClientRegistrar = soapresult.Descendants("NewX_AVM-DE_ClientRegistrar").First().Value;
            this.ClientRegistrarPort = Convert.ToInt32(soapresult.Descendants("NewX_AVM-DE_ClientRegistrarPort").First().Value);
            this.PhoneName = soapresult.Descendants("NewX_AVM-DE_PhoneName").First().Value;
            this.ClientId = soapresult.Descendants("NewX_AVM-DE_ClientId").First().Value;
            this.OutGoingNumber = soapresult.Descendants("NewX_AVM-DE_OutGoingNumber").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ClientUsername
        /// </summary>
        public string ClientUsername { get; internal set;}

        /// <summary>
        /// gets or sets the ClientRegistrar
        /// </summary>
        public string ClientRegistrar { get; internal set;}

        /// <summary>
        /// gets or sets the ClientRegistrarPort
        /// </summary>
        public Int32 ClientRegistrarPort { get; internal set;}

        /// <summary>
        /// gets or sets the PhoneName
        /// </summary>
        public string PhoneName { get; internal set;}

        /// <summary>
        /// gets or sets the ClientId
        /// </summary>
        public string ClientId { get; internal set;}

        /// <summary>
        /// gets or sets the OutGoingNumber
        /// </summary>
        public string OutGoingNumber { get; internal set;}

        #endregion
    }
}