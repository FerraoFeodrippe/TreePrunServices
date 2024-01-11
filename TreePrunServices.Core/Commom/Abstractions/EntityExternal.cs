using TreePrunServices.Core.Commom.ObjectValues;

namespace TreePrunServices.Core.Commom.Abstractions
{
    public abstract class EntityExternal<T>(ExternalIds externalIds): Entity<T> where T : struct
    {
        public ExternalIds ExternalsIds { get; private set; } = externalIds;
    }
}
