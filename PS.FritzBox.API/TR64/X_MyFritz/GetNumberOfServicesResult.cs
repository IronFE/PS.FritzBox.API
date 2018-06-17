using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_MyFritz
{
    /// <summary>
    /// result object for GetNumberOfServices
    /// </summary>
    public class GetNumberOfServicesResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetNumberOfServicesResult(XDocument soapresult)
        {
            this.NumberOfServices = Convert.ToInt32(soapresult.Descendants("NewNumberOfServices").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the NumberOfServices
        /// </summary>
        public Int32 NumberOfServices { get; internal set;}

        #endregion
    }
}