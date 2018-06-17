using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for X_GetClients
    /// </summary>
    public class X_GetClientsResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetClientsResult(XDocument soapresult)
        {
            this.ClientList = soapresult.Descendants("NewX_AVM-DE_ClientList").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ClientList
        /// </summary>
        public string ClientList { get; internal set;}

        #endregion
    }
}