using TreePrunServices.Core.Commom.Definitions.DataFlow;
using TreePrunServices.Core.TreeManagement.Entities;

namespace TreePrunServices.Core.TreeManagement.Contracts
{
    public interface IServiceOrderRepository
    {
        Task<IEnumerable<ServiceOrder>> GetServicesOrdersAsync(DataRequest request);
    }
}
