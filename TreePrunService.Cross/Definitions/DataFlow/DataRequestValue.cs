
namespace TreePrunServices.Cross.Definitions.DataFlow
{
    public class DataRequestValue
    {
        private readonly Dictionary<string, object> _values;

        private DataRequestValue()
        {
            _values = [];
        }

        public static DataRequestValue Create()
        {
            return new DataRequestValue();
        }

        public static DataRequestValue Create(string key, object value)
        {
            return new DataRequestValue().Add(key, value);
        }

        public DataRequestValue Add(string key, object value)
        {
            _values.Add(key, value);
            return this;
        }

        public IReadOnlyDictionary<string, object> Values => _values.AsReadOnly();
        public object GetValue(string key) => _values[key];
    }
}
