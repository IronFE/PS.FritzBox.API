using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for X_GetNumberOfNumbers
    /// </summary>
    public class X_GetNumberOfNumbersResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetNumberOfNumbersResult(XDocument soapresult)
        {
            this.NumberOfNumbers = Convert.ToInt32(soapresult.Descendants("NewNumberOfNumbers").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the NumberOfNumbers
        /// </summary>
        public Int32 NumberOfNumbers { get; internal set;}

        #endregion
    }
}