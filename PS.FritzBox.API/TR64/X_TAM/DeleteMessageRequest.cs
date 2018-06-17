using System;

namespace PS.FritzBox.API.TR64.X_TAM
{
    /// <summary>
    /// request object for DeleteMessage
    /// </summary>
    public class DeleteMessageRequest
    {
        /// <summary>
        /// gets or sets the Index
        /// </summary>
        public Int32 Index { get; set;}

        /// <summary>
        /// gets or sets the MessageIndex
        /// </summary>
        public Int32 MessageIndex { get; set;}
    }
}