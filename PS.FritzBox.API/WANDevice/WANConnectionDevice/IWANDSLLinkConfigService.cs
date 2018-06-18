using System.Threading.Tasks;
using PS.FritzBox.API.WANDevice.WANConnectionDevice;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    /// <summary>
    /// interface for wan dls link services
    /// </summary>
    public interface IWANDSLLinkConfigService
    {
        ConnectionSettings ConnectionSettings { get; set; }

        Task<GetATMEncapsulationResult> GetATMEncapsulationAsync();
        Task<GetAutoConfigResult> GetAutoConfigAsync();
        Task<GetDestinationAddressResult> GetDestinationAddressAsync();
        Task<GetDSLLinkInfoResult> GetDSLLinkInfoAsync();
        Task SetATMEncapsulationAsync(SetATMEncapsulationRequest request);
        Task SetDestinationAddressAsync(SetDestinationAddressRequest request);
        Task SetDSLLinkTypeAsync(SetDSLLinkTypeRequest request);
    }
}