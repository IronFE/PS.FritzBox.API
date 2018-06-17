using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for GetMaxVoIPNumbers
    /// </summary>
    public class GetMaxVoIPNumbersResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetMaxVoIPNumbersResult(XDocument soapresult)
        {
            this.MaxVoIPNumbers = Convert.ToInt32(soapresult.Descendants("NewMaxVoIPNumbers").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the MaxVoIPNumbers
        /// </summary>
        public Int32 MaxVoIPNumbers { get; internal set;}

        #endregion
    }
}