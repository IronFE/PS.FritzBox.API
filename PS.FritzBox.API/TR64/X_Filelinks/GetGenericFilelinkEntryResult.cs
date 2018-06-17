using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Filelinks
{
    /// <summary>
    /// result object for GetGenericFilelinkEntry
    /// </summary>
    public class GetGenericFilelinkEntryResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetGenericFilelinkEntryResult(XDocument soapresult)
        {
            this.ID = soapresult.Descendants("NewID").First().Value;
            this.Valid = soapresult.Descendants("NewValid").First().Value == "1";
            this.Path = soapresult.Descendants("NewPath").First().Value;
            this.IsDirectory = soapresult.Descendants("NewIsDirectory").First().Value == "1";
            this.Url = soapresult.Descendants("NewUrl").First().Value;
            this.Username = soapresult.Descendants("NewUsername").First().Value;
            this.AccessCountLimit = Convert.ToInt32(soapresult.Descendants("NewAccessCountLimit").First().Value);
            this.AccessCount = Convert.ToInt32(soapresult.Descendants("NewAccessCount").First().Value);
            this.Expire = Convert.ToInt32(soapresult.Descendants("NewExpire").First().Value);
            this.ExpireDate = Convert.ToDateTime(soapresult.Descendants("NewExpireDate").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the ID
        /// </summary>
        public string ID { get; internal set;}

        /// <summary>
        /// gets or sets the Valid
        /// </summary>
        public bool Valid { get; internal set;}

        /// <summary>
        /// gets or sets the Path
        /// </summary>
        public string Path { get; internal set;}

        /// <summary>
        /// gets or sets the IsDirectory
        /// </summary>
        public bool IsDirectory { get; internal set;}

        /// <summary>
        /// gets or sets the Url
        /// </summary>
        public string Url { get; internal set;}

        /// <summary>
        /// gets or sets the Username
        /// </summary>
        public string Username { get; internal set;}

        /// <summary>
        /// gets or sets the AccessCountLimit
        /// </summary>
        public Int32 AccessCountLimit { get; internal set;}

        /// <summary>
        /// gets or sets the AccessCount
        /// </summary>
        public Int32 AccessCount { get; internal set;}

        /// <summary>
        /// gets or sets the Expire
        /// </summary>
        public Int32 Expire { get; internal set;}

        /// <summary>
        /// gets or sets the ExpireDate
        /// </summary>
        public DateTime ExpireDate { get; internal set;}

        #endregion
    }
}