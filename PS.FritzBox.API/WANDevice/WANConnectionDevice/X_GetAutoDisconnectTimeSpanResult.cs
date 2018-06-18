using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for X_GetAutoDisconnectTimeSpan
    /// </summary>
    public class X_GetAutoDisconnectTimeSpanResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetAutoDisconnectTimeSpanResult(XDocument soapresult)
        {
            this.DisconnectPreventionEnable = soapresult.Descendants("NewX_AVM-DE_DisconnectPreventionEnable").First().Value == "1";
            this.DisconnectPreventionHour = Convert.ToInt32(soapresult.Descendants("NewX_AVM-DE_DisconnectPreventionHour").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the DisconnectPreventionEnable
        /// </summary>
        public bool DisconnectPreventionEnable { get; internal set;}

        /// <summary>
        /// gets or sets the DisconnectPreventionHour
        /// </summary>
        public Int32 DisconnectPreventionHour { get; internal set;}

        #endregion
    }
}