using System;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// request object for SetEnableByIndex
    /// </summary>
    public class SetEnableByIndexRequest
    {
        /// <summary>
        /// gets or sets the Index
        /// </summary>
        public Int32 Index { get; set;}

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; set;}
    }
}