using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace TreePrunServices.Core.Commom.ObjectValues
{
    public class ExternalIds
    {
        public IReadOnlyDictionary<string, string>? Values{ get; private set; }

        public static ExternalIds Empty => new ();

        private ExternalIds()
        {
            Values = ImmutableDictionary<string, string>.Empty;
        }

        public ExternalIds(IDictionary<string, string>? values)
        {
            ArgumentNullException.ThrowIfNull(values);
            Values = new ReadOnlyDictionary<string, string>(values);
        }
    }
}
