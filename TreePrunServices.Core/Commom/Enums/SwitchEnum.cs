
using TreePrunServices.Cross.Definitions.Enums;

namespace TreePrunServices.Core.Commom.Enums
{
    public sealed class SwitchEnum: BaseEnum<SwitchEnum>
    {
        public static readonly SwitchEnum Selector = new(1, "SELECTOR");
        public static readonly SwitchEnum Regulator = new(2, "REGULATOR");

        private SwitchEnum(int value, string description) : base(value, description) { }
    }
}
