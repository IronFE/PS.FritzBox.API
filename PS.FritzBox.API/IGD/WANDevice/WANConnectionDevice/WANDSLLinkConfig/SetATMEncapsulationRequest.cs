using System;

namespace PS.FritzBox.API.IGD.WANDevice.WANConnectionDevice.WANDSLLinkConfig
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