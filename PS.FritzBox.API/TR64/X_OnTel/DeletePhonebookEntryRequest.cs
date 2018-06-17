using System;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// request object for DeletePhonebookEntry
    /// </summary>
    public class DeletePhonebookEntryRequest
    {
        /// <summary>
        /// gets or sets the PhonebookID
        /// </summary>
        public Int32 PhonebookID { get; set;}

        /// <summary>
        /// gets or sets the PhonebookEntryID
        /// </summary>
        public Int32 PhonebookEntryID { get; set;}
    }
}