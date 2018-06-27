using GenericRepositoryExample.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Data.EF
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AppDbContext Context { get; set; }

        public RepositoryBase(AppDbContext context)
        {
            Context = context;
        }
        public void Create(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindByConditionAync(Expression<Func<T, bool>> expression)
        {
            return await Context.Set<T>().Where(expression).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await Context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
        }
    }
}
