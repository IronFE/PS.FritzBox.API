using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.DeviceConfig
{
    /// <summary>
    /// result object for X_GenerateUUID
    /// </summary>
    public class X_GenerateUUIDResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GenerateUUIDResult(XDocument soapresult)
        {
            this.UUID = Convert.ToInt32(soapresult.Descendants("NewUUID").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the UUID
        /// </summary>
        public string UUID { get; internal set;}

        #endregion
    }
}