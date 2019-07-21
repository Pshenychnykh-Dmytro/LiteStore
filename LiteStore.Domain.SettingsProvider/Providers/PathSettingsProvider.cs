using LiteStore.Domain.SettingsProvider.Interfaces;
using System;

namespace LiteStore.Domain.SettingsProvider.Providers
{
    public class PathSettingsProvider : IPathSettingsProvider
    {  
        public PathSettingsProvider(string settingsEnv)
        {
            RootPath = Environment.GetEnvironmentVariable(settingsEnv);
        }

        public string RootPath { get; }
    }
}
