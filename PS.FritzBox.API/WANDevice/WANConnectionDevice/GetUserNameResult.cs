using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for GetUserName
    /// </summary>
    public class GetUserNameResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetUserNameResult(XDocument soapresult)
        {
            this.UserName = soapresult.Descendants("NewUserName").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the UserName
        /// </summary>
        public string UserName { get; internal set;}

        #endregion
    }
}