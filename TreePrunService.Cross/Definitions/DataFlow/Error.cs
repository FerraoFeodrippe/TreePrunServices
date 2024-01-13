
namespace TreePrunServices.Cross.Definitions.DataFlow
{
    public class Error
    {
        private readonly Dictionary<string, string> _dicMessages ;

        public static Error Empty() => new();

        private Error() { _dicMessages = [];  }

        public Error(string topic, string message)
        {
            _dicMessages = new Dictionary<string, string>() { { topic, message } };
        }

        public void AddMessage(string topic, string message)
        {
            _dicMessages.Add(topic, message);
        }

        public IEnumerable<string> GetTopics() { return _dicMessages.Keys; }
        public IEnumerable<string> GetMessages() { return _dicMessages.Values; }

        /// <summary>
        /// Gets the Dictionary Representation of Messages
        /// </summary>
        /// <returns></returns>
        public IReadOnlyDictionary<string, string> ErrorMessages => _dicMessages.AsReadOnly();


        /// <summary>
        /// If there is any error returns true, false otherside.
        /// </summary>
        public bool AnyError => _dicMessages.Count != 0;
    }
}
