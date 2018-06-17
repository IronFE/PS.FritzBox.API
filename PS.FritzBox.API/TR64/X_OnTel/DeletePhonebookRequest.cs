using System;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// request object for DeletePhonebook
    /// </summary>
    public class DeletePhonebookRequest
    {
        /// <summary>
        /// gets or sets the PhonebookID
        /// </summary>
        public Int32 PhonebookID { get; set;}

        /// <summary>
        /// gets or sets the PhonebookExtraID
        /// </summary>
        public string PhonebookExtraID { get; set;}
    }
}