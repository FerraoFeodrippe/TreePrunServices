using Microsoft.Extensions.Configuration;

namespace TreePrunServices.Cross.Settings
{
    public static class SettingsManager
    {
        private static IConfiguration? _settings;

        public static IConfiguration? Get(string key)
        {
            return _settings?.GetSection(key);
        }

        public static void Start(IConfiguration settings)
        {
            _settings = settings;
        }
    }
}
