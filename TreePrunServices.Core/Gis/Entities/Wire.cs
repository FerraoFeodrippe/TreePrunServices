using TreePrunServices.Core.Commom.Abstractions;
using TreePrunServices.Core.Commom.Enum;
using TreePrunServices.Core.Commom.ObjectValues;

namespace TreePrunServices.Core.Gis.Entities
{
    public class Wire: Entity<long>
    {
        public string? Description { get; set; }
        public required NetworkEnum Network { get; set; }
        public required string WireSpecification { get; set; }
        public required UnitMeasure WireGauge { get; set; }
        public required GeoCoordinate GeoCoordinate1 { get; set; }
        public required GeoCoordinate GeoCoordinate2 { get; set; }
        public required UnitMeasure WireLength { get; set; }
    }
}
