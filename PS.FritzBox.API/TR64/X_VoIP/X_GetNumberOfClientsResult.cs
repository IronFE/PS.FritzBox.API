using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for X_GetNumberOfClients
    /// </summary>
    public class X_GetNumberOfClientsResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetNumberOfClientsResult(XDocument soapresult)
        {
            this.NumberOfClients = Convert.ToInt32(soapresult.Descendants("NewX_AVM-DE_NumberOfClients").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the NumberOfClients
        /// </summary>
        public Int32 NumberOfClients { get; internal set;}

        #endregion
    }
}