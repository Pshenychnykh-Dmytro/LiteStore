using LiteStore.Domain.SettingsProvider.Interfaces;
using LiteStore.Domain.SettingsProvider.Models;

namespace LiteStore.Domain.SettingsProvider.Providers
{
    public class DbSettingsProvider : BaseSettingsProvider<DbSettings>, IDbSettingsProvider
    {
        public DbSettingsProvider(IPathSettingsProvider pathSettingsProvider) : base(
            pathSettingsProvider,
            Properties.Settings.Default.DbSettingsFile)
        { }

        public string SqlConnectionString => Settings.SqlConnectionString;

        public string MongoConnectionString => Settings.MongoConnectionString;

        public string HibernateConnectionString => Settings.HibernateConnectionString;
    }
}
