using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteStore.Domain.SettingsProvider.Interfaces
{
    public interface IPathSettingsProvider
    {        
        string RootPath { get; }
    }
}
