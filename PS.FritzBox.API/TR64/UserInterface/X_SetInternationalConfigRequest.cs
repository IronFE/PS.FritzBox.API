using System;

namespace PS.FritzBox.API.TR64.UserInterface
{
    /// <summary>
    /// request object for X_SetInternationalConfig
    /// </summary>
    public class X_SetInternationalConfigRequest
    {
        /// <summary>
        /// gets or sets the Language
        /// </summary>
        public string Language { get; set;}

        /// <summary>
        /// gets or sets the Country
        /// </summary>
        public string Country { get; set;}

        /// <summary>
        /// gets or sets the Annex
        /// </summary>
        public string Annex { get; set;}
    }
}