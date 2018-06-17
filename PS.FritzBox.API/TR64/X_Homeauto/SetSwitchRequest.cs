using System;

namespace PS.FritzBox.API.TR64.X_Homeauto
{
    /// <summary>
    /// request object for SetSwitch
    /// </summary>
    public class SetSwitchRequest
    {
        /// <summary>
        /// gets or sets the AIN
        /// </summary>
        public string AIN { get; set;}

        /// <summary>
        /// gets or sets the SwitchState
        /// </summary>
        public SwitchState SwitchState { get; set;}
    }
}