using System;

namespace PS.FritzBox.API.TR64.X_Storage
{
    /// <summary>
    /// request object for SetFTPServerWAN
    /// </summary>
    public class SetFTPServerWANRequest
    {
        /// <summary>
        /// gets or sets the FTPWANEnable
        /// </summary>
        public bool FTPWANEnable { get; set;}

        /// <summary>
        /// gets or sets the FTPWANSSLOnly
        /// </summary>
        public bool FTPWANSSLOnly { get; set;}
    }
}