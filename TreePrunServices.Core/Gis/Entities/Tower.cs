
using TreePrunServices.Core.Commom.Abstractions;
using TreePrunServices.Core.Commom.Enums;
using TreePrunServices.Core.Commom.ObjectValues;

namespace TreePrunServices.Core.Gis.Entities
{
    public class Tower: Entity<long>
    {
        public string? Description {  get; set; }
        public required GeoCoordinate GeoCoordinate { get; set; }
        public required ZoneEnum Zone { get; set; }
        public required UnitMeasure Height { get; set; }

    }
}
