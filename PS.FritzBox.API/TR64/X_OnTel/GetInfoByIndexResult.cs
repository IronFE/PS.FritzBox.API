using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// result object for GetInfoByIndex
    /// </summary>
    public class GetInfoByIndexResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetInfoByIndexResult(XDocument soapresult)
        {
            this.Enable = soapresult.Descendants("NewEnable").First().Value == "1";
            this.Status = soapresult.Descendants("NewStatus").First().Value;
            this.LastConnect = soapresult.Descendants("NewLastConnect").First().Value;
            this.Url = soapresult.Descendants("NewUrl").First().Value;
            this.ServiceId = soapresult.Descendants("NewServiceId").First().Value;
            this.Username = soapresult.Descendants("NewUsername").First().Value;
            this.Name = soapresult.Descendants("NewName").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; internal set;}

        /// <summary>
        /// gets or sets the Status
        /// </summary>
        public string Status { get; internal set;}

        /// <summary>
        /// gets or sets the LastConnect
        /// </summary>
        public string LastConnect { get; internal set;}

        /// <summary>
        /// gets or sets the Url
        /// </summary>
        public string Url { get; internal set;}

        /// <summary>
        /// gets or sets the ServiceId
        /// </summary>
        public string ServiceId { get; internal set;}

        /// <summary>
        /// gets or sets the Username
        /// </summary>
        public string Username { get; internal set;}

        /// <summary>
        /// gets or sets the Name
        /// </summary>
        public string Name { get; internal set;}

        #endregion
    }
}