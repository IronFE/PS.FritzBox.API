using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.X_Storage
{
    /// <summary>
    /// result object for GetInfo
    /// </summary>
    public class GetInfoResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetInfoResult(XDocument soapresult)
        {
            this.FTPEnable = soapresult.Descendants("NewFTPEnable").First().Value == "1";
            this.FTPStatus = soapresult.Descendants("NewFTPStatus").First().Value;
            this.SMBEnable = soapresult.Descendants("NewSMBEnable").First().Value == "1";
            this.FTPWANEnable = soapresult.Descendants("NewFTPWANEnable").First().Value == "1";
            this.FTPWANSSLOnly = soapresult.Descendants("NewFTPWANSSLOnly").First().Value == "1";
            this.FTPWANPort = Convert.ToInt32(soapresult.Descendants("NewFTPWANPort").First().Value);
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the FTPEnable
        /// </summary>
        public bool FTPEnable { get; internal set;}

        /// <summary>
        /// gets or sets the FTPStatus
        /// </summary>
        public string FTPStatus { get; internal set;}

        /// <summary>
        /// gets or sets the SMBEnable
        /// </summary>
        public bool SMBEnable { get; internal set;}

        /// <summary>
        /// gets or sets the FTPWANEnable
        /// </summary>
        public bool FTPWANEnable { get; internal set;}

        /// <summary>
        /// gets or sets the FTPWANSSLOnly
        /// </summary>
        public bool FTPWANSSLOnly { get; internal set;}

        /// <summary>
        /// gets or sets the FTPWANPort
        /// </summary>
        public Int32 FTPWANPort { get; internal set;}

        #endregion
    }
}