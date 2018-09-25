using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.React.Common.Infrastructure
{
    public interface IConfigurationManager
    {
        string GetConnectionString(string name = "DefaultConnection");
    }
}