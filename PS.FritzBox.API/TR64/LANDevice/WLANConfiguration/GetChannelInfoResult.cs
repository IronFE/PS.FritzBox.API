using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// result object for GetChannelInfo
    /// </summary>
    public class GetChannelInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetChannelInfoResult(XDocument soapresult)
        {
            this.Channel = Convert.ToInt32(soapresult.Descendants("NewChannel").First().Value);
            this.PossibleChannels = soapresult.Descendants("NewPossibleChannels").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Channel
        /// </summary>
        public Int32 Channel { get; internal set;}

        /// <summary>
        /// gets or sets the PossibleChannels
        /// </summary>
        public string PossibleChannels { get; internal set;}

        #endregion
    }
}