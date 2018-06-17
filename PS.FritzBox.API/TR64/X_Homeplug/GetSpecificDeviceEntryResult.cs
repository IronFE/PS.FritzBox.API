using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Homeplug
{
    /// <summary>
    /// result object for GetSpecificDeviceEntry
    /// </summary>
    public class GetSpecificDeviceEntryResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetSpecificDeviceEntryResult(XDocument soapresult)
        {
            this.Active = soapresult.Descendants("NewActive").First().Value == "1";
            this.Name = soapresult.Descendants("NewName").First().Value;
            this.Model = soapresult.Descendants("NewModel").First().Value;
            this.UpdateAvailable = soapresult.Descendants("NewUpdateAvailable").First().Value == "1";
            this.UpdateSuccessful = (UpdateSuccessful)Enum.Parse(typeof(UpdateSuccessful), soapresult.Descendants("NewUpdateSuccessful").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Active
        /// </summary>
        public bool Active { get; internal set;}

        /// <summary>
        /// gets or sets the Name
        /// </summary>
        public string Name { get; internal set;}

        /// <summary>
        /// gets or sets the Model
        /// </summary>
        public string Model { get; internal set;}

        /// <summary>
        /// gets or sets the UpdateAvailable
        /// </summary>
        public bool UpdateAvailable { get; internal set;}

        /// <summary>
        /// gets or sets the UpdateSuccessful
        /// </summary>
        public UpdateSuccessful UpdateSuccessful { get; internal set;}

        #endregion
    }
}