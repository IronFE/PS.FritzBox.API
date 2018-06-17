using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for GetSecurityKeys
    /// </summary>
    public class GetSecurityKeysResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetSecurityKeysResult(XDocument soapresult)
        {
            this.WEPKey0 = soapresult.Descendants("NewWEPKey0").First().Value;
            this.WEPKey1 = soapresult.Descendants("NewWEPKey1").First().Value;
            this.WEPKey2 = soapresult.Descendants("NewWEPKey2").First().Value;
            this.WEPKey3 = soapresult.Descendants("NewWEPKey3").First().Value;
            this.PreSharedKey = soapresult.Descendants("NewPreSharedKey").First().Value;
            this.KeyPassphrase = soapresult.Descendants("NewKeyPassphrase").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the WEPKey0
        /// </summary>
        public string WEPKey0 { get; internal set;}

        /// <summary>
        /// gets or sets the WEPKey1
        /// </summary>
        public string WEPKey1 { get; internal set;}

        /// <summary>
        /// gets or sets the WEPKey2
        /// </summary>
        public string WEPKey2 { get; internal set;}

        /// <summary>
        /// gets or sets the WEPKey3
        /// </summary>
        public string WEPKey3 { get; internal set;}

        /// <summary>
        /// gets or sets the PreSharedKey
        /// </summary>
        public string PreSharedKey { get; internal set;}

        /// <summary>
        /// gets or sets the KeyPassphrase
        /// </summary>
        public string KeyPassphrase { get; internal set;}

        #endregion
    }
}