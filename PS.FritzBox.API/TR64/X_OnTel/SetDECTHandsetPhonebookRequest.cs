using System;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// request object for SetDECTHandsetPhonebook
    /// </summary>
    public class SetDECTHandsetPhonebookRequest
    {
        /// <summary>
        /// gets or sets the DectID
        /// </summary>
        public Int32 DectID { get; set;}

        /// <summary>
        /// gets or sets the PhonebookID
        /// </summary>
        public Int32 PhonebookID { get; set;}
    }
}