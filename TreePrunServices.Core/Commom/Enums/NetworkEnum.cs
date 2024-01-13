using TreePrunServices.Cross.Definitions.Enums;

namespace TreePrunServices.Core.Commom.Enums
{
    public sealed class NetworkEnum: BaseEnum<NetworkEnum>
    {
        public static readonly NetworkEnum At = new(1, "AT");
        public static readonly NetworkEnum Bt = new(2, "BT");
        public static readonly NetworkEnum Mt = new(3, "MT");

        private NetworkEnum(int value, string description):base(value, description) { }
    }
}
