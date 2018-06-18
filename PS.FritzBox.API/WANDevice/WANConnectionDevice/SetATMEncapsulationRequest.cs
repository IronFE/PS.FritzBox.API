using System;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// request object for SetATMEncapsulation
    /// </summary>
    public class SetATMEncapsulationRequest
    {
        /// <summary>
        /// gets or sets the ATMEncapsulation
        /// </summary>
        public ATMEncapsulation ATMEncapsulation { get; set;}
    }
}