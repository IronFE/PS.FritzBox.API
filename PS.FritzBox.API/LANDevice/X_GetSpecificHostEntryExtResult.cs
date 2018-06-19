using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.Hosts
{
    /// <summary>
    /// result object for X_GetSpecificHostEntryExt
    /// </summary>
    public class X_GetSpecificHostEntryExtResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetSpecificHostEntryExtResult(XDocument soapresult)
        {
            this.IPAddress = soapresult.Descendants("NewIPAddress").First().Value;
            this.Active = soapresult.Descendants("NewActive").First().Value == "1";
            this.HostName = soapresult.Descendants("NewHostName").First().Value;
            this.InterfaceType = soapresult.Descendants("NewInterfaceType").First().Value;
            this.Port = Convert.ToInt32(soapresult.Descendants("NewX_AVM-DE_Port").First().Value);
            this.Speed = Convert.ToInt32(soapresult.Descendants("NewX_AVM-DE_Speed").First().Value);
            this.UpdateAvailable = soapresult.Descendants("NewX_AVM-DE_UpdateAvailable").First().Value == "1";
            this.UpdateSuccessful = (UpdateSuccessful)Enum.Parse(typeof(UpdateSuccessful), soapresult.Descendants("NewX_AVM-DE_UpdateSuccessful").First().Value);
            this.InfoURL = soapresult.Descendants("NewX_AVM-DE_InfoURL").First().Value;
            this.Model = soapresult.Descendants("NewX_AVM-DE_Model").First().Value;
            this.URL = soapresult.Descendants("NewX_AVM-DE_URL").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the IPAddress
        /// </summary>
        public string IPAddress { get; internal set;}

        /// <summary>
        /// gets or sets the Active
        /// </summary>
        public bool Active { get; internal set;}

        /// <summary>
        /// gets or sets the HostName
        /// </summary>
        public string HostName { get; internal set;}

        /// <summary>
        /// gets or sets the InterfaceType
        /// </summary>
        public string InterfaceType { get; internal set;}

        /// <summary>
        /// gets or sets the Port
        /// </summary>
        public Int32 Port { get; internal set;}

        /// <summary>
        /// gets or sets the Speed
        /// </summary>
        public Int32 Speed { get; internal set;}

        /// <summary>
        /// gets or sets the UpdateAvailable
        /// </summary>
        public bool UpdateAvailable { get; internal set;}

        /// <summary>
        /// gets or sets the UpdateSuccessful
        /// </summary>
        public UpdateSuccessful UpdateSuccessful { get; internal set;}

        /// <summary>
        /// gets or sets the InfoURL
        /// </summary>
        public string InfoURL { get; internal set;}

        /// <summary>
        /// gets or sets the Model
        /// </summary>
        public string Model { get; internal set;}

        /// <summary>
        /// gets or sets the URL
        /// </summary>
        public string URL { get; internal set;}

        #endregion
    }
}