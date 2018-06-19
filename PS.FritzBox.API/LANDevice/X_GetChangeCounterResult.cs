using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.Hosts
{
    /// <summary>
    /// result object for X_GetChangeCounter
    /// </summary>
    public class X_GetChangeCounterResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetChangeCounterResult(XDocument soapresult)
        {
            this.ChangeCounter = Convert.ToInt32(soapresult.Descendants("NewX_AVM-DE_ChangeCounter").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ChangeCounter
        /// </summary>
        public Int32 ChangeCounter { get; internal set;}

        #endregion
    }
}