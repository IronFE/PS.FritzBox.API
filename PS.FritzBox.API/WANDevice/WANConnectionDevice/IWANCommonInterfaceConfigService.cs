using System.Threading.Tasks;
using PS.FritzBox.API.WANDevice;

namespace PS.FritzBox.API.WANDevice
{
    /// <summary>
    /// interface for WAN Common Interface config service
    /// </summary>
    public interface IWANCommonInterfaceConfigService
    {
        /// <summary>
        /// Gets o rsets the connection settings
        /// </summary>
        ConnectionSettings ConnectionSettings { get; set; }

        /// <summary>
        /// Method to get the common link properties
        /// </summary>
        /// <returns>the common link result</returns>
        Task<GetCommonLinkPropertiesResult> GetCommonLinkPropertiesAsync();

        /// <summary>
        /// Method to get the total bytes received
        /// </summary>
        /// <returns>the total bytes received result</returns>
        Task<GetTotalBytesReceivedResult> GetTotalBytesReceivedAsync();

        /// <summary>
        /// Method to get the total bytes sent
        /// </summary>
        /// <returns>the total bytes sent result</returns>
        Task<GetTotalBytesSentResult> GetTotalBytesSentAsync();

        /// <summary>
        /// Method to get the total packets received
        /// </summary>
        /// <returns>the total packats received result</returns>
        Task<GetTotalPacketsReceivedResult> GetTotalPacketsReceivedAsync();

        /// <summary>
        /// Method to get the total packets sent
        /// </summary>
        /// <returns>the total packets sent result</returns>
        Task<GetTotalPacketsSentResult> GetTotalPacketsSentAsync();
    }
}