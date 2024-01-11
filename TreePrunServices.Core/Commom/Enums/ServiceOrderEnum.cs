
namespace TreePrunServices.Core.Commom.Enums
{
    public sealed class ServiceOrderEnum : BaseEnum<SwitchEnum>
    {
        public static readonly ServiceOrderEnum TreePruning = new(1, "TREE_PRUNING");
        public static readonly ServiceOrderEnum TrackCleaning = new (2, "TRACK_CLEANING");

        private ServiceOrderEnum(int value, string description) : base(value, description) { }
    }
}
