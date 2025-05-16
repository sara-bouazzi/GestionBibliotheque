using T.Core.Interfaces;

namespace T.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TContext context;

        public UnitOfWork(TContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(context);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
