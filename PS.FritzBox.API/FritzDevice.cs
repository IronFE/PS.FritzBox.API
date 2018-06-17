using PS.FritzBox.API.Base;
using PS.FritzBox.API.TR64.DeviceInfo;
using PS.FritzBox.API.TR64.LANDevice;
using PS.FritzBox.API.TR64.WANDevice;
using PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.FritzBox.API
{
    /// <summary>
    /// class representing a fritz device
    /// </summary>
    public class FritzDevice
    {
        internal FritzDevice()
        {
        }

        /// <summary>
        /// Method to parse the udp response
        /// </summary>
        /// <param name="address"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        internal static FritzDevice ParseResponse(IPAddress address, string response)
        {
            FritzDevice device = new FritzDevice();
            device.IPAddress = address;
            device.Location = device.ParseResponse(response);
            if (device.Location == null)
                return null;
            else
                return device;
        }

        /// <summary>
        /// Method to parse the response
        /// </summary>
        /// <param name="response">the response</param>
        private Uri ParseResponse(string response)
        {
            Dictionary<string, string> values = response.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                                                 .Skip(1)
                                                 .Select(line => line.Split(new[] { ":" }, 2, StringSplitOptions.None))
                                                 .Where(parts => parts.Length == 2)
                .                                 ToDictionary(parts => parts[0].ToLowerInvariant().Trim(), parts => parts[1].Trim());

            if (values.ContainsKey("location"))
            {
                string location = values["location"];
                
                Uri uri = Uri.TryCreate(location, UriKind.Absolute, out Uri locationUri) ? locationUri : new UriBuilder() { Scheme = "unknown", Host = location }.Uri;
                this.Port = uri.Port;
                return uri;
            }
            else
                return null;
        }

        /// <summary>
        /// Gets the device type
        /// </summary>
        public string DeviceType { get; internal set; }

        /// <summary>
        /// Gets the friendly name
        /// </summary>
        public string FriendlyName { get; internal set; }

        /// <summary>
        /// Gets the manufacturer
        /// </summary>
        public string Manufacturer { get; internal set; }

        /// <summary>
        /// Gets the model name
        /// </summary>
        public string ModelName { get; internal set; }

        /// <summary>
        /// Gets the model description
        /// </summary>
        public string ModelDescription { get; internal set; }

        /// <summary>
        /// Gets the manufacturer url
        /// </summary>
        public string ManufacturerUrl { get; internal set; }

        /// <summary>
        /// Gets the ip address
        /// </summary>
        public IPAddress IPAddress { get; internal set; }

        /// <summary>
        /// Gets the port
        /// </summary>
        public int Port { get; internal set; }

        /// <summary>
        /// Gets or sets the location
        /// </summary>
        public Uri Location { get; set; }

        /// <summary>
        /// Gets the model number
        /// </summary>
        public string ModelNumber { get; internal set; }

        /// <summary>
        /// Gets the udn
        /// </summary>
        public string UDN { get; internal set; }

        /// <summary>
        /// the list of valid services
        /// </summary>
        private List<Type> _validServices = new List<Type>();

        /// <summary>
        /// Method to check if the device contains a given service
        /// </summary>
        /// <typeparam name="T">the service type parameter</typeparam>
        /// <returns>true if the device containes the given service</returns>
        public bool ContainsService<T>()
        {
            return this._validServices.Contains(typeof(T));
        }

        /// <summary>
        /// Method to get the base url
        /// </summary>
        /// <returns>the service client</returns>
        public async Task<string> GetBaseUrl()
        {
            string baseUrl = $"http://{this.IPAddress}:{this.Port}";
            // get the security port
            GetSecurityPortResult result = await new DeviceInfoService(baseUrl, 10000).GetSecurityPortAsync();
            return $"https://{this.IPAddress}:{result.SecurityPort}";
        }

        /// <summary>
        /// Method to parse the fritz tr64 description
        /// </summary>
        /// <param name="data">the description data</param>
        public void ParseTR64Desc(string data)
        {
            XDocument document = XDocument.Parse(data);
            XElement deviceRoot = this.GetElement(document.Root, "device");
            
            if (deviceRoot != null)
            {
                // read device info
                this.DeviceType = this.GetElementValue(deviceRoot, "deviceType");
                this.FriendlyName = this.GetElementValue(deviceRoot, "friendlyName");
                this.Manufacturer = this.GetElementValue(deviceRoot, "manufacturer");
                this.ManufacturerUrl = this.GetElementValue(deviceRoot, "manufacturerURL");
                this.ModelName = this.GetElementValue(deviceRoot, "modelName");
                this.ModelDescription = this.GetElementValue(deviceRoot, "modelDescription");
                this.ModelNumber = this.GetElementValue(deviceRoot, "modelNumber");
                this.UDN = this.GetElementValue(deviceRoot, "UDN");
            }
        }
               
        /// <summary>
        /// Mehtod to get an element
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private XElement GetElement(XElement parent, string key)
        {
            return parent.Element(parent.Document.Root.Name.Namespace + key);
        }

        /// <summary>
        /// Method to get an element value
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private string GetElementValue(XElement parent, string key)
        {
            return this.GetElement(parent, key).Value;
        }

        /// <summary>
        /// Method to get element collection
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private IEnumerable<XElement> GetElements(XElement parent, string key)
        {
            return parent.Elements(parent.Document.Root.Name.Namespace + key);
        }
               
    }
}
