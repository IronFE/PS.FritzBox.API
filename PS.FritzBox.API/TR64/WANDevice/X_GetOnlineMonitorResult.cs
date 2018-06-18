using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.TR64.WANDevice
{
    /// <summary>
    /// result object for X_GetOnlineMonitor
    /// </summary>
    public class X_GetOnlineMonitorResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal X_GetOnlineMonitorResult(XDocument soapresult)
        {
            this.TotalNumberSyncGroups = Convert.ToInt32(soapresult.Descendants("NewTotalNumberSyncGroups").First().Value);
            this.SyncGroupName = soapresult.Descendants("NewSyncGroupName").First().Value;
            this.SyncGroupMode = soapresult.Descendants("NewSyncGroupMode").First().Value;
            this.max_ds = Convert.ToInt32(soapresult.Descendants("Newmax_ds").First().Value);
            this.max_us = Convert.ToInt32(soapresult.Descendants("Newmax_us").First().Value);
            this.ds_current_bps = soapresult.Descendants("Newds_current_bps").First().Value;
            this.mc_current_bps = soapresult.Descendants("Newmc_current_bps").First().Value;
            this.us_current_bps = soapresult.Descendants("Newus_current_bps").First().Value;
            this.prio_realtime_bps = soapresult.Descendants("Newprio_realtime_bps").First().Value;
            this.prio_high_bps = soapresult.Descendants("Newprio_high_bps").First().Value;
            this.prio_default_bps = soapresult.Descendants("Newprio_default_bps").First().Value;
            this.prio_low_bps = soapresult.Descendants("Newprio_low_bps").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the TotalNumberSyncGroups
        /// </summary>
        public Int32 TotalNumberSyncGroups { get; internal set;}

        /// <summary>
        /// gets or sets the SyncGroupName
        /// </summary>
        public string SyncGroupName { get; internal set;}

        /// <summary>
        /// gets or sets the SyncGroupMode
        /// </summary>
        public string SyncGroupMode { get; internal set;}

        /// <summary>
        /// gets or sets the max_ds
        /// </summary>
        public Int32 max_ds { get; internal set;}

        /// <summary>
        /// gets or sets the max_us
        /// </summary>
        public Int32 max_us { get; internal set;}

        /// <summary>
        /// gets or sets the ds_current_bps
        /// </summary>
        public string ds_current_bps { get; internal set;}

        /// <summary>
        /// gets or sets the mc_current_bps
        /// </summary>
        public string mc_current_bps { get; internal set;}

        /// <summary>
        /// gets or sets the us_current_bps
        /// </summary>
        public string us_current_bps { get; internal set;}

        /// <summary>
        /// gets or sets the prio_realtime_bps
        /// </summary>
        public string prio_realtime_bps { get; internal set;}

        /// <summary>
        /// gets or sets the prio_high_bps
        /// </summary>
        public string prio_high_bps { get; internal set;}

        /// <summary>
        /// gets or sets the prio_default_bps
        /// </summary>
        public string prio_default_bps { get; internal set;}

        /// <summary>
        /// gets or sets the prio_low_bps
        /// </summary>
        public string prio_low_bps { get; internal set;}

        #endregion
    }
}