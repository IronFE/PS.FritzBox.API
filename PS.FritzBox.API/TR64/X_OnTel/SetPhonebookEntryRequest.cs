using System;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// request object for SetPhonebookEntry
    /// </summary>
    public class SetPhonebookEntryRequest
    {
        /// <summary>
        /// gets or sets the PhonebookID
        /// </summary>
        public Int32 PhonebookID { get; set;}

        /// <summary>
        /// gets or sets the PhonebookEntryID
        /// </summary>
        public Int32 PhonebookEntryID { get; set;}

        /// <summary>
        /// gets or sets the PhonebookEntryData
        /// </summary>
        public string PhonebookEntryData { get; set;}
    }
}