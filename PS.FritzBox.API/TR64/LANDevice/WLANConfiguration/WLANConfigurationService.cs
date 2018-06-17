using PS.FritzBox.API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.LANDevice.WLANConfiguration
{
    /// <summary>
    /// client proxy class for WLANConfiguration service
    /// </summary>
    public class WLANConfigurationService : FritzServiceBase
    {
        #region Construction / Destruction

        /// <summary>
        /// constructor for WLANConfigurationService
        /// </summary>
        /// <param name="url">the service url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        public WLANConfigurationService(string url, int timeout) : base(url, timeout)
        {
        }

        /// <summary>
        /// constructor for WLANConfigurationService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        public WLANConfigurationService(string url, int timeout, string username) : this(url, timeout)
        {
            this.ConnectionSettings.UserName = username;
        }

        /// <summary>
        /// constructor for WLANConfigurationService
        /// </summary>
        /// <param name="url">the base url</param>
        /// <param name="timeout">the timeout in milliseconds</param>
        /// <param name="username">the connection user name</param>
        /// <param name="password">the connection password</param>
        public WLANConfigurationService(string url, int timeout, string username, string password) : this(url, timeout, username)
        {
            this.ConnectionSettings.Password = password;
        }

        /// <summary>
        /// constructor for WLANConfigurationService
        /// </summary>
        /// <param name="connectionSettings">the connection settings</param>
        public WLANConfigurationService(ConnectionSettings connectionSettings) : base(connectionSettings)
        {
            this.ConnectionSettings = connectionSettings;
        }

        #endregion

        #region Properties

        /// <summary>
        /// gets the control url
        /// </summary>
        protected override string ControlUrl => "/upnp/control/wlanconfig1";

        /// <summary>
        /// gets the request namespace
        /// </summary>
        protected override string RequestNameSpace => "urn:dslforum-org:service:WLANConfiguration:1";
		
        /// <summary>
        /// gets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        #endregion

        #region Methods

        /// <summary>
        /// method to invoke SetEnable on service
        /// </summary>
        /// <param name="request">the request for the action SetEnable</param>
        public async Task SetEnableAsync(SetEnableRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewEnable", request.Enable ? "1" : "0")
            };
            await base.InvokeAsync("SetEnable", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetInfo on service
        /// </summary>
        /// <returns>the result of the action GetInfo</returns>
        public async Task<GetInfoResult> GetInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetInfo", null);
            return new GetInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetConfig on service
        /// </summary>
        /// <param name="request">the request for the action SetConfig</param>
        public async Task SetConfigAsync(SetConfigRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewMaxBitRate", request.MaxBitRate.ToString()),
                new SOAP.SoapRequestParameter("NewChannel", request.Channel.ToString()),
                new SOAP.SoapRequestParameter("NewSSID", request.SSID.ToString()),
                new SOAP.SoapRequestParameter("NewBeaconType", request.BeaconType.ToString()),
                new SOAP.SoapRequestParameter("NewMACAddressControlEnabled", request.MACAddressControlEnabled ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewBasicEncryptionModes", request.BasicEncryptionModes.ToString()),
                new SOAP.SoapRequestParameter("NewBasicAuthenticationMode", request.BasicAuthenticationMode.ToString())
            };
            await base.InvokeAsync("SetConfig", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke SetSecurityKeys on service
        /// </summary>
        /// <param name="request">the request for the action SetSecurityKeys</param>
        public async Task SetSecurityKeysAsync(SetSecurityKeysRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewWEPKey0", request.WEPKey0.ToString()),
                new SOAP.SoapRequestParameter("NewWEPKey1", request.WEPKey1.ToString()),
                new SOAP.SoapRequestParameter("NewWEPKey2", request.WEPKey2.ToString()),
                new SOAP.SoapRequestParameter("NewWEPKey3", request.WEPKey3.ToString()),
                new SOAP.SoapRequestParameter("NewPreSharedKey", request.PreSharedKey.ToString()),
                new SOAP.SoapRequestParameter("NewKeyPassphrase", request.KeyPassphrase.ToString())
            };
            await base.InvokeAsync("SetSecurityKeys", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetSecurityKeys on service
        /// </summary>
        /// <returns>the result of the action GetSecurityKeys</returns>
        public async Task<GetSecurityKeysResult> GetSecurityKeysAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetSecurityKeys", null);
            return new GetSecurityKeysResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetDefaultWEPKeyIndex on service
        /// </summary>
        /// <param name="request">the request for the action SetDefaultWEPKeyIndex</param>
        public async Task SetDefaultWEPKeyIndexAsync(SetDefaultWEPKeyIndexRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewDefaultWEPKeyIndex", request.DefaultWEPKeyIndex.ToString())
            };
            await base.InvokeAsync("SetDefaultWEPKeyIndex", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetDefaultWEPKeyIndex on service
        /// </summary>
        /// <returns>the result of the action GetDefaultWEPKeyIndex</returns>
        public async Task<GetDefaultWEPKeyIndexResult> GetDefaultWEPKeyIndexAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetDefaultWEPKeyIndex", null);
            return new GetDefaultWEPKeyIndexResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetBasBeaconSecurityProperties on service
        /// </summary>
        /// <param name="request">the request for the action SetBasBeaconSecurityProperties</param>
        public async Task SetBasBeaconSecurityPropertiesAsync(SetBasBeaconSecurityPropertiesRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewBasicEncryptionModes", request.BasicEncryptionModes.ToString()),
                new SOAP.SoapRequestParameter("NewBasicAuthenticationMode", request.BasicAuthenticationMode.ToString())
            };
            await base.InvokeAsync("SetBasBeaconSecurityProperties", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetBasBeaconSecurityProperties on service
        /// </summary>
        /// <returns>the result of the action GetBasBeaconSecurityProperties</returns>
        public async Task<GetBasBeaconSecurityPropertiesResult> GetBasBeaconSecurityPropertiesAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetBasBeaconSecurityProperties", null);
            return new GetBasBeaconSecurityPropertiesResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetStatistics on service
        /// </summary>
        /// <returns>the result of the action GetStatistics</returns>
        public async Task<GetStatisticsResult> GetStatisticsAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetStatistics", null);
            return new GetStatisticsResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetPacketStatistics on service
        /// </summary>
        /// <returns>the result of the action GetPacketStatistics</returns>
        public async Task<GetPacketStatisticsResult> GetPacketStatisticsAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetPacketStatistics", null);
            return new GetPacketStatisticsResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetBSSID on service
        /// </summary>
        /// <returns>the result of the action GetBSSID</returns>
        public async Task<GetBSSIDResult> GetBSSIDAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetBSSID", null);
            return new GetBSSIDResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetSSID on service
        /// </summary>
        /// <returns>the result of the action GetSSID</returns>
        public async Task<GetSSIDResult> GetSSIDAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetSSID", null);
            return new GetSSIDResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetSSID on service
        /// </summary>
        /// <param name="request">the request for the action SetSSID</param>
        public async Task SetSSIDAsync(SetSSIDRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewSSID", request.SSID.ToString())
            };
            await base.InvokeAsync("SetSSID", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetBeaconType on service
        /// </summary>
        /// <returns>the result of the action GetBeaconType</returns>
        public async Task<GetBeaconTypeResult> GetBeaconTypeAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetBeaconType", null);
            return new GetBeaconTypeResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetBeaconType on service
        /// </summary>
        /// <param name="request">the request for the action SetBeaconType</param>
        public async Task SetBeaconTypeAsync(SetBeaconTypeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewBeaconType", request.BeaconType.ToString())
            };
            await base.InvokeAsync("SetBeaconType", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetChannelInfo on service
        /// </summary>
        /// <returns>the result of the action GetChannelInfo</returns>
        public async Task<GetChannelInfoResult> GetChannelInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetChannelInfo", null);
            return new GetChannelInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetChannel on service
        /// </summary>
        /// <param name="request">the request for the action SetChannel</param>
        public async Task SetChannelAsync(SetChannelRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewChannel", request.Channel.ToString())
            };
            await base.InvokeAsync("SetChannel", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetBeaconAdvertisement on service
        /// </summary>
        /// <returns>the result of the action GetBeaconAdvertisement</returns>
        public async Task<GetBeaconAdvertisementResult> GetBeaconAdvertisementAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetBeaconAdvertisement", null);
            return new GetBeaconAdvertisementResult(soapResult);
        }

        /// <summary>
        /// method to invoke SetBeaconAdvertisement on service
        /// </summary>
        /// <param name="request">the request for the action SetBeaconAdvertisement</param>
        public async Task SetBeaconAdvertisementAsync(SetBeaconAdvertisementRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewBeaconAdvertisementEnabled", request.BeaconAdvertisementEnabled ? "1" : "0")
            };
            await base.InvokeAsync("SetBeaconAdvertisement", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke GetTotalAssociations on service
        /// </summary>
        /// <returns>the result of the action GetTotalAssociations</returns>
        public async Task<GetTotalAssociationsResult> GetTotalAssociationsAsync()
        {
            XDocument soapResult = await base.InvokeAsync("GetTotalAssociations", null);
            return new GetTotalAssociationsResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetGenericAssociatedDeviceInfo on service
        /// </summary>
        /// <param name="request">the request for the action GetGenericAssociatedDeviceInfo</param>
        /// <returns>the result of the action GetGenericAssociatedDeviceInfo</returns>
        public async Task<GetGenericAssociatedDeviceInfoResult> GetGenericAssociatedDeviceInfoAsync(GetGenericAssociatedDeviceInfoRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewAssociatedDeviceIndex", request.AssociatedDeviceIndex.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetGenericAssociatedDeviceInfo", parameters.ToArray());
            return new GetGenericAssociatedDeviceInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke GetSpecificAssociatedDeviceInfo on service
        /// </summary>
        /// <param name="request">the request for the action GetSpecificAssociatedDeviceInfo</param>
        /// <returns>the result of the action GetSpecificAssociatedDeviceInfo</returns>
        public async Task<GetSpecificAssociatedDeviceInfoResult> GetSpecificAssociatedDeviceInfoAsync(GetSpecificAssociatedDeviceInfoRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewAssociatedDeviceMACAddress", request.AssociatedDeviceMACAddress.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("GetSpecificAssociatedDeviceInfo", parameters.ToArray());
            return new GetSpecificAssociatedDeviceInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_SetHighFrequencyBand on service
        /// </summary>
        /// <param name="request">the request for the action X_SetHighFrequencyBand</param>
        public async Task X_SetHighFrequencyBandAsync(X_SetHighFrequencyBandRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewEnableHighFrequency", request.EnableHighFrequency ? "1" : "0")
            };
            await base.InvokeAsync("X_SetHighFrequencyBand", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetStickSurfEnable on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetStickSurfEnable</param>
        public async Task X_SetStickSurfEnableAsync(X_SetStickSurfEnableRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewStickSurfEnable", request.StickSurfEnable ? "1" : "0")
            };
            await base.InvokeAsync("X_AVM-DE_SetStickSurfEnable", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetIPTVOptimized on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetIPTVOptimized</returns>
        public async Task<X_GetIPTVOptimizedResult> X_GetIPTVOptimizedAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetIPTVOptimized", null);
            return new X_GetIPTVOptimizedResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetIPTVOptimized on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetIPTVOptimized</param>
        public async Task X_SetIPTVOptimizedAsync(X_SetIPTVOptimizedRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_IPTVoptimize", request.IPTVoptimize ? "1" : "0")
            };
            await base.InvokeAsync("X_AVM-DE_SetIPTVOptimized", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetNightControl on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetNightControl</returns>
        public async Task<X_GetNightControlResult> X_GetNightControlAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetNightControl", null);
            return new X_GetNightControlResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetWLANHybridMode on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetWLANHybridMode</returns>
        public async Task<X_GetWLANHybridModeResult> X_GetWLANHybridModeAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetWLANHybridMode", null);
            return new X_GetWLANHybridModeResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetWLANHybridMode on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetWLANHybridMode</param>
        public async Task X_SetWLANHybridModeAsync(X_SetWLANHybridModeRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewEnable", request.Enable ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewBeaconType", request.BeaconType.ToString()),
                new SOAP.SoapRequestParameter("NewKeyPassphrase", request.KeyPassphrase.ToString()),
                new SOAP.SoapRequestParameter("NewSSID", request.SSID.ToString()),
                new SOAP.SoapRequestParameter("NewBSSID", request.BSSID.ToString()),
                new SOAP.SoapRequestParameter("NewTrafficMode", request.TrafficMode.ToString()),
                new SOAP.SoapRequestParameter("NewManualSpeed", request.ManualSpeed ? "1" : "0"),
                new SOAP.SoapRequestParameter("NewMaxSpeedDS", request.MaxSpeedDS.ToString()),
                new SOAP.SoapRequestParameter("NewMaxSpeedUS", request.MaxSpeedUS.ToString())
            };
            await base.InvokeAsync("X_AVM-DE_SetWLANHybridMode", parameters.ToArray());
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetWLANExtInfo on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetWLANExtInfo</returns>
        public async Task<X_GetWLANExtInfoResult> X_GetWLANExtInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetWLANExtInfo", null);
            return new X_GetWLANExtInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_GetWPSInfo on service
        /// </summary>
        /// <returns>the result of the action X_AVM-DE_GetWPSInfo</returns>
        public async Task<X_GetWPSInfoResult> X_GetWPSInfoAsync()
        {
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_GetWPSInfo", null);
            return new X_GetWPSInfoResult(soapResult);
        }

        /// <summary>
        /// method to invoke X_AVM-DE_SetWPSConfig on service
        /// </summary>
        /// <param name="request">the request for the action X_AVM-DE_SetWPSConfig</param>
        /// <returns>the result of the action X_AVM-DE_SetWPSConfig</returns>
        public async Task<X_SetWPSConfigResult> X_SetWPSConfigAsync(X_SetWPSConfigRequest request)
        {
            List<SOAP.SoapRequestParameter> parameters = new List<SOAP.SoapRequestParameter>()
            {
                new SOAP.SoapRequestParameter("NewX_AVM-DE_WPSMode", request.WPSMode.ToString()),
                new SOAP.SoapRequestParameter("NewX_AVM-DE_WPSClientPIN", request.WPSClientPIN.ToString())
            };
            XDocument soapResult = await base.InvokeAsync("X_AVM-DE_SetWPSConfig", parameters.ToArray());
            return new X_SetWPSConfigResult(soapResult);
        }

        #endregion
    }
}