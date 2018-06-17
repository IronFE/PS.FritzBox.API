using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Storage
{
    /// <summary>
    /// result object for GetUserInfo
    /// </summary>
    public class GetUserInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetUserInfoResult(XDocument soapresult)
        {
            this.Enable = soapresult.Descendants("NewEnable").First().Value == "1";
            this.Username = soapresult.Descendants("NewUsername").First().Value;
            this.NetworkAccessReadOnly = soapresult.Descendants("NewX_AVM-DE_NetworkAccessReadOnly").First().Value == "1";
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; internal set;}

        /// <summary>
        /// gets or sets the Username
        /// </summary>
        public string Username { get; internal set;}

        /// <summary>
        /// gets or sets the NetworkAccessReadOnly
        /// </summary>
        public bool NetworkAccessReadOnly { get; internal set;}

        #endregion
    }
}