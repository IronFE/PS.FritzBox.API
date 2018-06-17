using System;

namespace PS.FritzBox.API.TR64.X_AppSetup
{
    /// <summary>
    /// request object for SetAppMessageReceiver
    /// </summary>
    public class SetAppMessageReceiverRequest
    {
        /// <summary>
        /// gets or sets the AppId
        /// </summary>
        public string AppId { get; set;}

        /// <summary>
        /// gets or sets the CryptAlgos
        /// </summary>
        public string CryptAlgos { get; set;}

        /// <summary>
        /// gets or sets the AppAVMAddress
        /// </summary>
        public string AppAVMAddress { get; set;}

        /// <summary>
        /// gets or sets the AppAVMPasswordHash
        /// </summary>
        public string AppAVMPasswordHash { get; set;}
    }
}