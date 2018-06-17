using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for X_GetPhonePort
    /// </summary>
    public class X_GetPhonePortResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetPhonePortResult(XDocument soapresult)
        {
            this.PhoneName = soapresult.Descendants("NewX_AVM-DE_PhoneName").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the PhoneName
        /// </summary>
        public string PhoneName { get; internal set;}

        #endregion
    }
}