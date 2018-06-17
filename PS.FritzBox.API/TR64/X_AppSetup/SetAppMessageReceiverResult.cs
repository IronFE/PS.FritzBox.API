using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_AppSetup
{
    /// <summary>
    /// result object for SetAppMessageReceiver
    /// </summary>
    public class SetAppMessageReceiverResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal SetAppMessageReceiverResult(XDocument soapresult)
        {
            this.EncryptionSecret = soapresult.Descendants("EncryptionSecret").First().Value;
            this.BoxSenderId = soapresult.Descendants("BoxSenderId").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the EncryptionSecret
        /// </summary>
        public string EncryptionSecret { get; internal set;}

        /// <summary>
        /// gets or sets the BoxSenderId
        /// </summary>
        public string BoxSenderId { get; internal set;}

        #endregion
    }
}