using TreePrunServices.Cross.Definitions.Enums;

namespace TreePrunServices.Core.Commom.Enums
{
    public sealed class ZoneEnum: BaseEnum<ZoneEnum>
    {
        public static readonly ZoneEnum Rural = new (1, "RURAL");
        public static readonly ZoneEnum Urban = new (2, "URBAN");

        private ZoneEnum(int value, string description): base(value, description) { }
    }
}
