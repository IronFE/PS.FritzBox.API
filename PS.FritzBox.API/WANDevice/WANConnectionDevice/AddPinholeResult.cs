using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// result object for AddPinhole
    /// </summary>
    public class AddPinholeResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal AddPinholeResult(XDocument soapresult)
        {
            this.UniqueID = Convert.ToInt32(soapresult.Descendants("UniqueID").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the UniqueID
        /// </summary>
        public Int32 UniqueID { get; internal set;}

        #endregion
    }
}