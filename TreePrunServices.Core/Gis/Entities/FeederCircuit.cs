using TreePrunServices.Core.Commom.Abstractions;
using TreePrunServices.Core.Commom.ObjectValues;

namespace TreePrunServices.Core.Gis.Entities
{
    public class FeederCircuit: Entity<long>
    {
        public string? Name { get; set; }
        public required GeoCoordinate GeoCoordinate { get; set; }
    }
}
