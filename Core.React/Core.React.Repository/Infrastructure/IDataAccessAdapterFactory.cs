using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Core.React.Repository.Infrastructure
{
    public interface IDataAccessAdapterFactory
    {
        IDataAccessAdapter GetAdapter();
    }
}