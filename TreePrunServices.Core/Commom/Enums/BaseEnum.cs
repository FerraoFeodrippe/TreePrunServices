namespace TreePrunServices.Core.Commom.Enums
{
    public abstract class BaseEnum<T> where T : BaseEnum<T>
    {
        public int Value { get; private set; }
        public string Description { get; private set; }

#pragma warning disable CS8619 // A anulabilidade de tipos de referência no valor não corresponde ao tipo de destino.
        private static readonly Dictionary<int, T> _dicEnum = typeof(T)
                .GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                .Where(f => f.FieldType == typeof(T) && f.GetValue(null) != null)
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
                .ToDictionary(f => ((T) f.GetValue(null)).Value, f => (T)(f.GetValue(null)) );
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
#pragma warning restore CS8619 // A anulabilidade de tipos de referência no valor não corresponde ao tipo de destino.

        protected BaseEnum(int value, string description)
        {
            Value = value;
            Description = description;
        }

        public static IEnumerable<T> GetAll()
        {
            return _dicEnum.Values;
        }

        public static T GetByDescription(string description)
        {
            return GetAll().Single(e => e.Description.Equals(description));
        }

        public static T GetByValue(int value)
        {
            return GetAll().Single(e => e.Value.Equals(value));
        }

        public override string ToString()
        {
            return Description;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
                                   
            BaseEnum <T> baseEnum = (BaseEnum<T>) obj;

            return Value.Equals(baseEnum.Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
