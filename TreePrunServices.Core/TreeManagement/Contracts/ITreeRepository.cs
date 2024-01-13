
using TreePrunServices.Core.TreeManagement.Entities;
using TreePrunServices.Cross.Definitions.DataFlow;

namespace TreePrunServices.Core.TreeManagement.Contracts
{
    public interface ITreeRepository
    {
        Task<IEnumerable<TreePruning>> GetTreesAsync(DataRequest request);
    }
}
