using System;

namespace PS.FritzBox.API.TR64.X_Homeauto
{
    /// <summary>
    /// request object for GetSpecificDeviceInfos
    /// </summary>
    public class GetSpecificDeviceInfosRequest
    {
        /// <summary>
        /// gets or sets the AIN
        /// </summary>
        public string AIN { get; set;}
    }
}