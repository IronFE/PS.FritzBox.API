using System;

namespace PS.FritzBox.API.TR64.X_Filelinks
{
    /// <summary>
    /// request object for SetFilelinkEntry
    /// </summary>
    public class SetFilelinkEntryRequest
    {
        /// <summary>
        /// gets or sets the ID
        /// </summary>
        public string ID { get; set;}

        /// <summary>
        /// gets or sets the AccessCountLimit
        /// </summary>
        public Int32 AccessCountLimit { get; set;}

        /// <summary>
        /// gets or sets the Expire
        /// </summary>
        public Int32 Expire { get; set;}
    }
}