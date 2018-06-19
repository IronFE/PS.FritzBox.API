using System.Threading.Tasks;
using PS.FritzBox.API.WANDevice.WANConnectionDevice;

namespace PS.FritzBox.API.WANDevice.WANConnectionDevice
{
    public interface IWANConnectionService
    {
        Task AddPortMappingAsync(AddPortMappingRequest request);
        Task DeletePortMappingAsync(DeletePortMappingRequest request);
        Task ForceTerminationAsync();
        Task<GetConnectionTypeInfoResult> GetConnectionTypeInfoAsync();
        Task<GetExternalIPAddressResult> GetExternalIPAddressAsync();
        Task<GetGenericPortMappingEntryResult> GetGenericPortMappingEntryAsync(GetGenericPortMappingEntryRequest request);
        Task<GetNATRSIPStatusResult> GetNATRSIPStatusAsync();
        Task<GetSpecificPortMappingEntryResult> GetSpecificPortMappingEntryAsync(GetSpecificPortMappingEntryRequest request);
        Task RequestConnectionAsync();
        Task SetConnectionTypeAsync(SetConnectionTypeRequest request);
    }
}