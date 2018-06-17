using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.UserInterface
{
    /// <summary>
    /// result object for X_DoPrepareCGI
    /// </summary>
    public class X_DoPrepareCGIResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_DoPrepareCGIResult(XDocument soapresult)
        {
            this.CGI = soapresult.Descendants("NewX_AVM-DE_CGI").First().Value;
            this.SessionID = soapresult.Descendants("NewX_AVM-DE_SessionID").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the CGI
        /// </summary>
        public string CGI { get; internal set;}

        /// <summary>
        /// gets or sets the SessionID
        /// </summary>
        public string SessionID { get; internal set;}

        #endregion
    }
}