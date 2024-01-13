using TreePrunServices.Core.Commom.Abstractions;
using TreePrunServices.Core.Commom.Enums;

namespace TreePrunServices.Core.TreeManagement.Entities
{
    public class ServiceOrder : Entity<long>
    {
        public string? Description { get; set; }
        public required ServiceOrderEnum Classification { get; set;}
        public required TreePruning TreePruning { get; set; }
        public string? Observation { get; set; }
    }
}
