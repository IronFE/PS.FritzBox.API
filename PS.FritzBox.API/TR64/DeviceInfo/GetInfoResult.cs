using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.DeviceInfo
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
            this.ManufacturerName = soapresult.Descendants("NewManufacturerName").First().Value;
            this.ManufacturerOUI = soapresult.Descendants("NewManufacturerOUI").First().Value;
            this.ModelName = soapresult.Descendants("NewModelName").First().Value;
            this.Description = soapresult.Descendants("NewDescription").First().Value;
            this.ProductClass = soapresult.Descendants("NewProductClass").First().Value;
            this.SerialNumber = soapresult.Descendants("NewSerialNumber").First().Value;
            this.SoftwareVersion = soapresult.Descendants("NewSoftwareVersion").First().Value;
            this.HardwareVersion = soapresult.Descendants("NewHardwareVersion").First().Value;
            this.SpecVersion = soapresult.Descendants("NewSpecVersion").First().Value;
            this.ProvisioningCode = soapresult.Descendants("NewProvisioningCode").First().Value;
            this.UpTime = Convert.ToInt32(soapresult.Descendants("NewUpTime").First().Value);
            this.DeviceLog = soapresult.Descendants("NewDeviceLog").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ManufacturerName
        /// </summary>
        public string ManufacturerName { get; internal set;}

        /// <summary>
        /// gets or sets the ManufacturerOUI
        /// </summary>
        public string ManufacturerOUI { get; internal set;}

        /// <summary>
        /// gets or sets the ModelName
        /// </summary>
        public string ModelName { get; internal set;}

        /// <summary>
        /// gets or sets the Description
        /// </summary>
        public string Description { get; internal set;}

        /// <summary>
        /// gets or sets the ProductClass
        /// </summary>
        public string ProductClass { get; internal set;}

        /// <summary>
        /// gets or sets the SerialNumber
        /// </summary>
        public string SerialNumber { get; internal set;}

        /// <summary>
        /// gets or sets the SoftwareVersion
        /// </summary>
        public string SoftwareVersion { get; internal set;}

        /// <summary>
        /// gets or sets the HardwareVersion
        /// </summary>
        public string HardwareVersion { get; internal set;}

        /// <summary>
        /// gets or sets the SpecVersion
        /// </summary>
        public string SpecVersion { get; internal set;}

        /// <summary>
        /// gets or sets the ProvisioningCode
        /// </summary>
        public string ProvisioningCode { get; internal set;}

        /// <summary>
        /// gets or sets the UpTime
        /// </summary>
        public Int32 UpTime { get; internal set;}

        /// <summary>
        /// gets or sets the DeviceLog
        /// </summary>
        public string DeviceLog { get; internal set;}

        #endregion
    }
}