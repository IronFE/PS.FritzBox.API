using System;

namespace PS.FritzBox.API.TR64.WANDevice
{
    /// <summary>
    /// request object for X_SetWANAccessType
    /// </summary>
    public class X_SetWANAccessTypeRequest
    {
        /// <summary>
        /// gets or sets the AccessType
        /// </summary>
        public string AccessType { get; set;}
    }
}