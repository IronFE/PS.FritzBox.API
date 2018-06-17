using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for GetSpecificAssociatedDeviceInfo
    /// </summary>
    public class GetSpecificAssociatedDeviceInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetSpecificAssociatedDeviceInfoResult(XDocument soapresult)
        {
            this.AssociatedDeviceIPAddress = soapresult.Descendants("NewAssociatedDeviceIPAddress").First().Value;
            this.AssociatedDeviceAuthState = soapresult.Descendants("NewAssociatedDeviceAuthState").First().Value == "1";
            this.Speed = Convert.ToInt32(soapresult.Descendants("NewX_AVM-DE_Speed").First().Value);
            this.SignalStrength = Convert.ToInt32(soapresult.Descendants("NewX_AVM-DE_SignalStrength").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the AssociatedDeviceIPAddress
        /// </summary>
        public string AssociatedDeviceIPAddress { get; internal set;}

        /// <summary>
        /// gets or sets the AssociatedDeviceAuthState
        /// </summary>
        public bool AssociatedDeviceAuthState { get; internal set;}

        /// <summary>
        /// gets or sets the Speed
        /// </summary>
        public Int32 Speed { get; internal set;}

        /// <summary>
        /// gets or sets the SignalStrength
        /// </summary>
        public Int32 SignalStrength { get; internal set;}

        #endregion
    }
}