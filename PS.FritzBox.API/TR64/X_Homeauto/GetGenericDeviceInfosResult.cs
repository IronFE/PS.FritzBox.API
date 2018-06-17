using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Homeauto
{
    /// <summary>
    /// result object for GetGenericDeviceInfos
    /// </summary>
    public class GetGenericDeviceInfosResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetGenericDeviceInfosResult(XDocument soapresult)
        {
            this.AIN = soapresult.Descendants("NewAIN").First().Value;
            this.DeviceId = Convert.ToInt32(soapresult.Descendants("NewDeviceId").First().Value);
            this.FunctionBitMask = Convert.ToInt32(soapresult.Descendants("NewFunctionBitMask").First().Value);
            this.FirmwareVersion = soapresult.Descendants("NewFirmwareVersion").First().Value;
            this.Manufacturer = soapresult.Descendants("NewManufacturer").First().Value;
            this.ProductName = soapresult.Descendants("NewProductName").First().Value;
            this.DeviceName = soapresult.Descendants("NewDeviceName").First().Value;
            this.Present = (Present)Enum.Parse(typeof(Present), soapresult.Descendants("NewPresent").First().Value);
            this.MultimeterIsEnabled = (MultimeterIsEnabled)Enum.Parse(typeof(MultimeterIsEnabled), soapresult.Descendants("NewMultimeterIsEnabled").First().Value);
            this.MultimeterIsValid = (MultimeterIsValid)Enum.Parse(typeof(MultimeterIsValid), soapresult.Descendants("NewMultimeterIsValid").First().Value);
            this.MultimeterPower = Convert.ToInt32(soapresult.Descendants("NewMultimeterPower").First().Value);
            this.MultimeterEnergy = Convert.ToInt32(soapresult.Descendants("NewMultimeterEnergy").First().Value);
            this.TemperatureIsEnabled = (TemperatureIsEnabled)Enum.Parse(typeof(TemperatureIsEnabled), soapresult.Descendants("NewTemperatureIsEnabled").First().Value);
            this.TemperatureIsValid = (TemperatureIsValid)Enum.Parse(typeof(TemperatureIsValid), soapresult.Descendants("NewTemperatureIsValid").First().Value);
            this.TemperatureCelsius = Convert.ToInt32(soapresult.Descendants("NewTemperatureCelsius").First().Value);
            this.TemperatureOffset = Convert.ToInt32(soapresult.Descendants("NewTemperatureOffset").First().Value);
            this.SwitchIsEnabled = (SwitchIsEnabled)Enum.Parse(typeof(SwitchIsEnabled), soapresult.Descendants("NewSwitchIsEnabled").First().Value);
            this.SwitchIsValid = (SwitchIsValid)Enum.Parse(typeof(SwitchIsValid), soapresult.Descendants("NewSwitchIsValid").First().Value);
            this.SwitchState = (SwitchState)Enum.Parse(typeof(SwitchState), soapresult.Descendants("NewSwitchState").First().Value);
            this.SwitchMode = (SwitchMode)Enum.Parse(typeof(SwitchMode), soapresult.Descendants("NewSwitchMode").First().Value);
            this.SwitchLock = soapresult.Descendants("NewSwitchLock").First().Value == "1";
            this.HkrIsEnabled = (HkrIsEnabled)Enum.Parse(typeof(HkrIsEnabled), soapresult.Descendants("NewHkrIsEnabled").First().Value);
            this.HkrIsValid = (HkrIsValid)Enum.Parse(typeof(HkrIsValid), soapresult.Descendants("NewHkrIsValid").First().Value);
            this.HkrIsTemperature = Convert.ToInt32(soapresult.Descendants("NewHkrIsTemperature").First().Value);
            this.HkrSetVentilStatus = (HkrSetVentilStatus)Enum.Parse(typeof(HkrSetVentilStatus), soapresult.Descendants("NewHkrSetVentilStatus").First().Value);
            this.HkrSetTemperature = Convert.ToInt32(soapresult.Descendants("NewHkrSetTemperature").First().Value);
            this.HkrReduceVentilStatus = (HkrReduceVentilStatus)Enum.Parse(typeof(HkrReduceVentilStatus), soapresult.Descendants("NewHkrReduceVentilStatus").First().Value);
            this.HkrReduceTemperature = Convert.ToInt32(soapresult.Descendants("NewHkrReduceTemperature").First().Value);
            this.HkrComfortVentilStatus = (HkrComfortVentilStatus)Enum.Parse(typeof(HkrComfortVentilStatus), soapresult.Descendants("NewHkrComfortVentilStatus").First().Value);
            this.HkrComfortTemperature = Convert.ToInt32(soapresult.Descendants("NewHkrComfortTemperature").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the AIN
        /// </summary>
        public string AIN { get; internal set;}

        /// <summary>
        /// gets or sets the DeviceId
        /// </summary>
        public Int32 DeviceId { get; internal set;}

        /// <summary>
        /// gets or sets the FunctionBitMask
        /// </summary>
        public Int32 FunctionBitMask { get; internal set;}

        /// <summary>
        /// gets or sets the FirmwareVersion
        /// </summary>
        public string FirmwareVersion { get; internal set;}

        /// <summary>
        /// gets or sets the Manufacturer
        /// </summary>
        public string Manufacturer { get; internal set;}

        /// <summary>
        /// gets or sets the ProductName
        /// </summary>
        public string ProductName { get; internal set;}

        /// <summary>
        /// gets or sets the DeviceName
        /// </summary>
        public string DeviceName { get; internal set;}

        /// <summary>
        /// gets or sets the Present
        /// </summary>
        public Present Present { get; internal set;}

        /// <summary>
        /// gets or sets the MultimeterIsEnabled
        /// </summary>
        public MultimeterIsEnabled MultimeterIsEnabled { get; internal set;}

        /// <summary>
        /// gets or sets the MultimeterIsValid
        /// </summary>
        public MultimeterIsValid MultimeterIsValid { get; internal set;}

        /// <summary>
        /// gets or sets the MultimeterPower
        /// </summary>
        public Int32 MultimeterPower { get; internal set;}

        /// <summary>
        /// gets or sets the MultimeterEnergy
        /// </summary>
        public Int32 MultimeterEnergy { get; internal set;}

        /// <summary>
        /// gets or sets the TemperatureIsEnabled
        /// </summary>
        public TemperatureIsEnabled TemperatureIsEnabled { get; internal set;}

        /// <summary>
        /// gets or sets the TemperatureIsValid
        /// </summary>
        public TemperatureIsValid TemperatureIsValid { get; internal set;}

        /// <summary>
        /// gets or sets the TemperatureCelsius
        /// </summary>
        public Int32 TemperatureCelsius { get; internal set;}

        /// <summary>
        /// gets or sets the TemperatureOffset
        /// </summary>
        public Int32 TemperatureOffset { get; internal set;}

        /// <summary>
        /// gets or sets the SwitchIsEnabled
        /// </summary>
        public SwitchIsEnabled SwitchIsEnabled { get; internal set;}

        /// <summary>
        /// gets or sets the SwitchIsValid
        /// </summary>
        public SwitchIsValid SwitchIsValid { get; internal set;}

        /// <summary>
        /// gets or sets the SwitchState
        /// </summary>
        public SwitchState SwitchState { get; internal set;}

        /// <summary>
        /// gets or sets the SwitchMode
        /// </summary>
        public SwitchMode SwitchMode { get; internal set;}

        /// <summary>
        /// gets or sets the SwitchLock
        /// </summary>
        public bool SwitchLock { get; internal set;}

        /// <summary>
        /// gets or sets the HkrIsEnabled
        /// </summary>
        public HkrIsEnabled HkrIsEnabled { get; internal set;}

        /// <summary>
        /// gets or sets the HkrIsValid
        /// </summary>
        public HkrIsValid HkrIsValid { get; internal set;}

        /// <summary>
        /// gets or sets the HkrIsTemperature
        /// </summary>
        public Int32 HkrIsTemperature { get; internal set;}

        /// <summary>
        /// gets or sets the HkrSetVentilStatus
        /// </summary>
        public HkrSetVentilStatus HkrSetVentilStatus { get; internal set;}

        /// <summary>
        /// gets or sets the HkrSetTemperature
        /// </summary>
        public Int32 HkrSetTemperature { get; internal set;}

        /// <summary>
        /// gets or sets the HkrReduceVentilStatus
        /// </summary>
        public HkrReduceVentilStatus HkrReduceVentilStatus { get; internal set;}

        /// <summary>
        /// gets or sets the HkrReduceTemperature
        /// </summary>
        public Int32 HkrReduceTemperature { get; internal set;}

        /// <summary>
        /// gets or sets the HkrComfortVentilStatus
        /// </summary>
        public HkrComfortVentilStatus HkrComfortVentilStatus { get; internal set;}

        /// <summary>
        /// gets or sets the HkrComfortTemperature
        /// </summary>
        public Int32 HkrComfortTemperature { get; internal set;}

        #endregion
    }
}