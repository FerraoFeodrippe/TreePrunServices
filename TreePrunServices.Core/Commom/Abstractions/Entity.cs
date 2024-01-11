namespace TreePrunServices.Core.Commom.Abstractions
{
    public abstract class Entity<T>(T id) where T : struct
    {
        public T Id { get; private set; } = id;

        public Entity(): this(default)
        {
        }
    }
}
