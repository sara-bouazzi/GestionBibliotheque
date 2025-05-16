using System.Collections.Generic;

namespace T.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        T? Get(int id);
        T? Get(string id);
        IList<T> GetAll();
        void Update(T entity);
    }
}
