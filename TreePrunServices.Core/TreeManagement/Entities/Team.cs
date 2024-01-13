
using TreePrunServices.Core.Commom.Abstractions;

namespace TreePrunServices.Core.TreeManagement.Entities
{
    public class Team: Entity<long>
    {
        public required string Name { get; set; }
        public required string[] ServicesClassification { get; set; }
        public required OperationalBase[] OperationalBases { get; set; }

    }
}
