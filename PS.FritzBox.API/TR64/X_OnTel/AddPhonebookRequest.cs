using System;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// request object for AddPhonebook
    /// </summary>
    public class AddPhonebookRequest
    {
        /// <summary>
        /// gets or sets the PhonebookExtraID
        /// </summary>
        public string PhonebookExtraID { get; set;}

        /// <summary>
        /// gets or sets the PhonebookName
        /// </summary>
        public string PhonebookName { get; set;}
    }
}