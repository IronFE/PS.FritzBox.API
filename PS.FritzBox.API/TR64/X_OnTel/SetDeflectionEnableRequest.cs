using System;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// request object for SetDeflectionEnable
    /// </summary>
    public class SetDeflectionEnableRequest
    {
        /// <summary>
        /// gets or sets the DeflectionId
        /// </summary>
        public Int32 DeflectionId { get; set;}

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; set;}
    }
}