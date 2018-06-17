using System;

namespace PS.FritzBox.API.TR64.X_MyFritz
{
    /// <summary>
    /// request object for SetServiceByIndex
    /// </summary>
    public class SetServiceByIndexRequest
    {
        /// <summary>
        /// gets or sets the Index
        /// </summary>
        public Int32 Index { get; set;}

        /// <summary>
        /// gets or sets the Enabled
        /// </summary>
        public bool Enabled { get; set;}

        /// <summary>
        /// gets or sets the Name
        /// </summary>
        public string Name { get; set;}

        /// <summary>
        /// gets or sets the Scheme
        /// </summary>
        public string Scheme { get; set;}

        /// <summary>
        /// gets or sets the Port
        /// </summary>
        public Int32 Port { get; set;}

        /// <summary>
        /// gets or sets the URLPath
        /// </summary>
        public string URLPath { get; set;}

        /// <summary>
        /// gets or sets the Type
        /// </summary>
        public string Type { get; set;}

        /// <summary>
        /// gets or sets the IPv4Address
        /// </summary>
        public string IPv4Address { get; set;}

        /// <summary>
        /// gets or sets the IPv6Address
        /// </summary>
        public string IPv6Address { get; set;}

        /// <summary>
        /// gets or sets the IPv6InterfaceID
        /// </summary>
        public string IPv6InterfaceID { get; set;}

        /// <summary>
        /// gets or sets the MACAddress
        /// </summary>
        public string MACAddress { get; set;}

        /// <summary>
        /// gets or sets the HostName
        /// </summary>
        public string HostName { get; set;}
    }
}