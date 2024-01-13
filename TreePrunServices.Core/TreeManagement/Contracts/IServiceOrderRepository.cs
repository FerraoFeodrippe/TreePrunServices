using TreePrunServices.Core.TreeManagement.Entities;
using TreePrunServices.Cross.Definitions.DataFlow;

namespace TreePrunServices.Core.TreeManagement.Contracts
{
    public interface IServiceOrderRepository
    {
        Task<IEnumerable<ServiceOrder>> GetServicesOrdersAsync(DataRequest request);
        Task<IEnumerable<Team>> GetTeamsAsync(DataRequest request);
        Task<IEnumerable<OperationalBase>> GetOperationalBasesAsync (DataRequest request);
    }
}
