using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// result object for GetDeflection
    /// </summary>
    public class GetDeflectionResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetDeflectionResult(XDocument soapresult)
        {
            this.Enable = soapresult.Descendants("NewEnable").First().Value == "1";
            this.Type = (Type)Enum.Parse(typeof(Type), soapresult.Descendants("NewType").First().Value);
            this.Number = soapresult.Descendants("NewNumber").First().Value;
            this.DeflectionToNumber = soapresult.Descendants("NewDeflectionToNumber").First().Value;
            this.Mode = (Mode)Enum.Parse(typeof(Mode), soapresult.Descendants("NewMode").First().Value);
            this.Outgoing = soapresult.Descendants("NewOutgoing").First().Value;
            this.PhonebookID = Convert.ToInt32(soapresult.Descendants("NewPhonebookID").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the Enable
        /// </summary>
        public bool Enable { get; internal set;}

        /// <summary>
        /// gets or sets the Type
        /// </summary>
        public Type Type { get; internal set;}

        /// <summary>
        /// gets or sets the Number
        /// </summary>
        public string Number { get; internal set;}

        /// <summary>
        /// gets or sets the DeflectionToNumber
        /// </summary>
        public string DeflectionToNumber { get; internal set;}

        /// <summary>
        /// gets or sets the Mode
        /// </summary>
        public Mode Mode { get; internal set;}

        /// <summary>
        /// gets or sets the Outgoing
        /// </summary>
        public string Outgoing { get; internal set;}

        /// <summary>
        /// gets or sets the PhonebookID
        /// </summary>
        public Int32 PhonebookID { get; internal set;}

        #endregion
    }
}