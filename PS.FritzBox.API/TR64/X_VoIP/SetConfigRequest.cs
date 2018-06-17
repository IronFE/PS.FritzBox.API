using System;

namespace PS.FritzBox.API.TR64.X_VoIP
{
    /// <summary>
    /// request object for SetConfig
    /// </summary>
    public class SetConfigRequest
    {
        /// <summary>
        /// gets or sets the FaxT38Enable
        /// </summary>
        public bool FaxT38Enable { get; set;}

        /// <summary>
        /// gets or sets the VoiceCoding
        /// </summary>
        public VoiceCoding VoiceCoding { get; set;}
    }
}