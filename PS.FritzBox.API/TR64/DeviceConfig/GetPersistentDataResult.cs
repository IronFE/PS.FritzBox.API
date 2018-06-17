using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.DeviceConfig
{
    /// <summary>
    /// result object for GetPersistentData
    /// </summary>
    public class GetPersistentDataResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetPersistentDataResult(XDocument soapresult)
        {
            this.PersistentData = soapresult.Descendants("NewPersistentData").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the PersistentData
        /// </summary>
        public string PersistentData { get; internal set;}

        #endregion
    }
}