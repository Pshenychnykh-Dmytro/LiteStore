using LiteStore.Domain.SettingsProvider.Interfaces;
using Newtonsoft.Json;
using System.IO;

namespace LiteStore.Domain.SettingsProvider.Providers
{
    public abstract class BaseSettingsProvider<T>
    {
        protected T Settings { get; private set; }

        public BaseSettingsProvider(IPathSettingsProvider pathProvider, string localPath)
        {
            var path = $"{pathProvider.RootPath}\\{Properties.Settings.Default.RootFolder}\\{localPath}";
            Init(path);
        }

        private void Init(string path)
        {
            string data = File.ReadAllText(path);
            Settings = JsonConvert.DeserializeObject<T>(data);
        }
    }
}
