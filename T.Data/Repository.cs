using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using T.Core.Interfaces;

namespace T.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly TContext context;

        public Repository(TContext context)
        {
            this.context = context;
        }

        public void Add(T entity) => context.Add(entity);

        public void Delete(T entity) => context.Remove(entity);

        public T? Get(int id) => context.Find<T>(id);

        public T? Get(string id) => context.Find<T>(id);

        public IList<T> GetAll() => context.Set<T>().ToList();

        public void Update(T entity) => context.Update(entity);
    }
}
