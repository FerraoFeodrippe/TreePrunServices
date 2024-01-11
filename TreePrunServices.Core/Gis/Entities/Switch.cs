
using TreePrunServices.Core.Commom.Abstractions;
using TreePrunServices.Core.Commom.ObjectValues;

namespace TreePrunServices.Core.Gis.Entities
{
    public class Switch: Entity<long>
    {
        public string? Description { get; set; }
        public required Switch SwitchClassification {  get; set; }
        public required GeoCoordinate GeoCoordinate { get; set; }
    }
}
