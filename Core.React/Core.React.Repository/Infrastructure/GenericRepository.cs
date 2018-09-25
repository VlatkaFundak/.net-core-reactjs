using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.React.Repository.Infrastructure
{
    public class GenericRepository
    {
        public GenericRepository(IDataAccessAdapterFactory dataAccessAdapterFactory)
        {
            DataAccessAdapterFactory = dataAccessAdapterFactory;
        }

        protected IDataAccessAdapterFactory DataAccessAdapterFactory { get; private set; }

        public Task<IDataAccessAdapter> GetAdapter()
        {
            var adapter = DataAccessAdapterFactory.GetAdapter();
            return Task.FromResult(adapter);
        }

        /// <summary>
        /// Gets the default commit order.
        /// </summary>
        /// <returns></returns>
        public List<UnitOfWorkBlockType> GetDefaultCommitOrder()
        {
            return new List<UnitOfWorkBlockType>(new UnitOfWorkBlockType[]{
                        UnitOfWorkBlockType.UpdatesPerformedDirectly,
                        UnitOfWorkBlockType.DeletesPerformedDirectly,
                        UnitOfWorkBlockType.Inserts,
                        UnitOfWorkBlockType.Updates,
                        UnitOfWorkBlockType.Deletes
                    });
        }
    }
}