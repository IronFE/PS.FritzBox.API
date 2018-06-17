using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for GetExistingVoIPNumbers
    /// </summary>
    public class GetExistingVoIPNumbersResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetExistingVoIPNumbersResult(XDocument soapresult)
        {
            this.ExistingVoIPNumbers = Convert.ToInt32(soapresult.Descendants("NewExistingVoIPNumbers").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ExistingVoIPNumbers
        /// </summary>
        public Int32 ExistingVoIPNumbers { get; internal set;}

        #endregion
    }
}