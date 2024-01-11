
using TreePrunServices.Core.Commom.Definitions.DataFlow;
using TreePrunServices.Core.TreeManagement.Entities;

namespace TreePrunServices.Core.TreeManagement.Contracts
{
    public interface ITreeRepository
    {
        Task<IEnumerable<Tree>> GetTreesAsync(DataRequest request);
    }
}
