using System;

namespace PS.FritzBox.API.TR64.X_AppSetup
{
    /// <summary>
    /// request object for RegisterApp
    /// </summary>
    public class RegisterAppRequest
    {
        /// <summary>
        /// gets or sets the AppId
        /// </summary>
        public string AppId { get; set;}

        /// <summary>
        /// gets or sets the AppDisplayName
        /// </summary>
        public string AppDisplayName { get; set;}

        /// <summary>
        /// gets or sets the AppDeviceMAC
        /// </summary>
        public string AppDeviceMAC { get; set;}

        /// <summary>
        /// gets or sets the AppUsername
        /// </summary>
        public string AppUsername { get; set;}

        /// <summary>
        /// gets or sets the AppPassword
        /// </summary>
        public string AppPassword { get; set;}

        /// <summary>
        /// gets or sets the AppRight
        /// </summary>
        public AppRight AppRight { get; set;}

        /// <summary>
        /// gets or sets the NasRight
        /// </summary>
        public NasRight NasRight { get; set;}

        /// <summary>
        /// gets or sets the PhoneRight
        /// </summary>
        public PhoneRight PhoneRight { get; set;}

        /// <summary>
        /// gets or sets the HomeautoRight
        /// </summary>
        public HomeautoRight HomeautoRight { get; set;}

        /// <summary>
        /// gets or sets the AppInternetRights
        /// </summary>
        public bool AppInternetRights { get; set;}
    }
}