using TreePrunServices.Core.Commom.Abstractions;
using TreePrunServices.Core.Commom.Enums;
using TreePrunServices.Core.Commom.ObjectValues;

namespace TreePrunServices.Core.Gis.Entities
{
    public class Pole: Entity<long>
    {
        public string? Description { get; set; }
        public required GeoCoordinate GeoCoordinate { get; set; }
        public required FeederCircuit[] FeederCircuits
        {
            get { return FeederCircuits; }
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                if (FeederCircuits.Length == 0)
                {
                    throw new ArgumentException("Need at last 1 FeederCircuit");
                }
            }
        }

        public required ZoneEnum Zone { get; set; }
    }
}
