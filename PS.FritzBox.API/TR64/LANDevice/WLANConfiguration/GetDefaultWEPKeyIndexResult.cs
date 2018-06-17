using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for GetDefaultWEPKeyIndex
    /// </summary>
    public class GetDefaultWEPKeyIndexResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetDefaultWEPKeyIndexResult(XDocument soapresult)
        {
            this.DefaultWEPKeyIndex = Convert.ToInt32(soapresult.Descendants("NewDefaultWEPKeyIndex").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the DefaultWEPKeyIndex
        /// </summary>
        public Int32 DefaultWEPKeyIndex { get; internal set;}

        #endregion
    }
}