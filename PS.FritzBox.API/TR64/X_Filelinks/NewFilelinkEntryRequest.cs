using System;

namespace PS.FritzBox.API.TR64.X_Filelinks
{
    /// <summary>
    /// request object for NewFilelinkEntry
    /// </summary>
    public class NewFilelinkEntryRequest
    {
        /// <summary>
        /// gets or sets the Path
        /// </summary>
        public string Path { get; set;}

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