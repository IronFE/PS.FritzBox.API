using System;

namespace PS.FritzBox.API.TR64.Time
{
    /// <summary>
    /// request object for SetNTPServers
    /// </summary>
    public class SetNTPServersRequest
    {
        /// <summary>
        /// gets or sets the NTPServer1
        /// </summary>
        public string NTPServer1 { get; set;}

        /// <summary>
        /// gets or sets the NTPServer2
        /// </summary>
        public string NTPServer2 { get; set;}
    }
}