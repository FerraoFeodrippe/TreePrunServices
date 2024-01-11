
using TreePrunServices.Core.Commom.Definitions.DataFlow;
using TreePrunServices.Core.Gis.Entities;

namespace TreePrunServices.Core.Gis.Contracts
{
    public interface IGisRepository
    {
        Task<IEnumerable<Pole>> GetPolesAsync(DataRequest request);
        Task<IEnumerable<PowerTransformer>> GetPowerTransformersAsync(DataRequest request);
        Task<IEnumerable<Switch>> GetSwitchAsync(DataRequest request);
        Task<IEnumerable<Tower>> GetTowersAsync(DataRequest request);
        Task<IEnumerable<Wire>> GetWiresAsync(DataRequest request);
    }
}
