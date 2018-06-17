using System;

namespace PS.FritzBox.API.TR64.ManagementServer
{
    /// <summary>
    /// request object for SetPeriodicInform
    /// </summary>
    public class SetPeriodicInformRequest
    {
        /// <summary>
        /// gets or sets the PeriodicInformEnable
        /// </summary>
        public bool PeriodicInformEnable { get; set;}

        /// <summary>
        /// gets or sets the PeriodicInformInterval
        /// </summary>
        public Int32 PeriodicInformInterval { get; set;}

        /// <summary>
        /// gets or sets the PeriodicInformTime
        /// </summary>
        public DateTime PeriodicInformTime { get; set;}
    }
}