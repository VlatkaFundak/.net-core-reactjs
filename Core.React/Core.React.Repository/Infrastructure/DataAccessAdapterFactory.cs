using Core.React.Common.Infrastructure;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.React.Repository.Infrastructure
{
    public class DataAccessAdapterFactory : IDataAccessAdapterFactory
    {
        public DataAccessAdapterFactory(IConfigurationManager configurationManager)
        {
            ConnectionString = configurationManager.GetConnectionString();
        }

        public string ConnectionString { get; private set; }

        public IDataAccessAdapter GetAdapter()
        {
            //TODO: create dataAccessAdapter

            return null;
        }
    }
}