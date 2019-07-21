using LiteStore.Domain.SettingsProvider.Interfaces;

namespace LiteStore.Domain.SettingsProvider.Models
{
    public class DbSettings : IDbSettingsProvider
    {
        public string SqlConnectionString { get; set; }

        public string MongoConnectionString { get; set; }

        public string HibernateConnectionString { get; set; }
    }
}
