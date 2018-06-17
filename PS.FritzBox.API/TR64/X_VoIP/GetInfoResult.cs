using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// result object for GetInfo
    /// </summary>
    public class GetInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetInfoResult(XDocument soapresult)
        {
            this.FaxT38Enable = soapresult.Descendants("NewFaxT38Enable").First().Value == "1";
            this.VoiceCoding = (VoiceCoding)Enum.Parse(typeof(VoiceCoding), soapresult.Descendants("NewVoiceCoding").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the FaxT38Enable
        /// </summary>
        public bool FaxT38Enable { get; internal set;}

        /// <summary>
        /// gets or sets the VoiceCoding
        /// </summary>
        public VoiceCoding VoiceCoding { get; internal set;}

        #endregion
    }
}