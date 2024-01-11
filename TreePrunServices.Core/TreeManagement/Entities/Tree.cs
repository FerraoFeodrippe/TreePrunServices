
using TreePrunServices.Core.Commom.Abstractions;
using TreePrunServices.Core.Commom.ObjectValues;
using TreePrunServices.Core.Gis.Entities;

namespace TreePrunServices.Core.TreeManagement.Entities
{
    public class Tree: Entity<long>
    {
        public required string Species { get; set; }
        public required Pole Pole { get; set; }
        public required GeoCoordinate GeoCoordinate { get; set; }
        public required UnitMeasure Height { get; set; }
        public required UnitMeasure Diameter { get; set; }
        public required UnitMeasure DistanceAt { get; set; }
        public required UnitMeasure DistanceBt { get; set; }
        public required UnitMeasure DistanceMt { get; set; }
    }
}
