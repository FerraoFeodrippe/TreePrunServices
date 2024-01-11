
using TreePrunServices.Core.Commom.Abstractions;
using TreePrunServices.Core.Commom.ObjectValues;

namespace TreePrunServices.Core.Gis.Entities
{
    public class PowerTransformer: Entity<long>
    {
        public string? Description {  get; set; }
        public required GeoCoordinate GeoCoordinate { get; set; }
    }
}
