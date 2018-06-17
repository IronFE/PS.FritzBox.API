using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_TAM
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
            this.Enable = soapresult.Descendants("NewEnable").First().Value == "1";
            this.Name = soapresult.Descendants("NewName").First().Value;
            this.TAMRunning = soapresult.Descendants("NewTAMRunning").First().Value == "1";
            this.Stick = Convert.ToInt32(soapresult.Descendants("NewStick").First().Value);
            this.Status = Convert.ToInt32(soapresult.Descendants("NewStatus").First().Value);
            this.Capacity = Convert.ToInt32(soapresult.Descendants("NewCapacity").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; internal set;}

        /// <summary>
        /// gets or sets the Name
        /// </summary>
        public string Name { get; internal set;}

        /// <summary>
        /// gets or sets the TAMRunning
        /// </summary>
        public bool TAMRunning { get; internal set;}

        /// <summary>
        /// gets or sets the Stick
        /// </summary>
        public Int32 Stick { get; internal set;}

        /// <summary>
        /// gets or sets the Status
        /// </summary>
        public Int32 Status { get; internal set;}

        /// <summary>
        /// gets or sets the Capacity
        /// </summary>
        public Int32 Capacity { get; internal set;}

        #endregion
    }
}