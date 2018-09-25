using Core.React.Common.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.React.API.Infrastructure
{
    public class WebConfigurationManager : IConfigurationManager
    {
        public WebConfigurationManager(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        public string GetConnectionString(string name = "DefaultConnection")
        {
            return Configuration.GetConnectionString(name);
        }
    }
}