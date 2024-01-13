using TreePrunServices.Core.Commom.Abstractions;
using TreePrunServices.Core.Commom.ObjectValues;

namespace TreePrunServices.Core.TreeManagement.Entities
{
    public class OperationalBase: Entity<long>
    {
        public required string Name { get; set; }
        public required GeoCoordinate GeoCoordinate { get; set; }
    }
}
