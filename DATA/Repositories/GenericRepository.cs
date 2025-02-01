using DATA.Context;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Repositories
{
    
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private CentreDbContext _context = null;
        private DbSet<TEntity> table = null;


        #region Constructor
        public GenericRepository(CentreDbContext context)
        {
            _context = context;
            table = _context.Set<TEntity>();
        }
        #endregion

        #region Get Function
        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> condition,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes)
        {
            try
            {
                IQueryable<TEntity> query = table;

                if (includes != null)
                {
                    query = includes(query);
                }
                if (condition != null)
                    return query.Where(condition).ToList();

                else
                    return query.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }

        public TEntity Get(Expression<Func<TEntity, bool>> condition,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null)
        {
            try
            {
                IQueryable<TEntity> query = table;

                if (includes != null)
                {
                    query = includes(query);
                }
                if (condition != null)
                    return query.Where(condition).FirstOrDefault();

                else
                    return query.FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                throw;
            }

        }

        #endregion

        #region Post Function
        public TEntity Add(TEntity Entity)
        {
            try
            {
                table.Add(Entity);
                _context.SaveChanges();

            }
            catch (Exception e)
            {

            }
            return Entity;
        }

        #endregion

        #region Update Function
        public TEntity Put(TEntity Entity)
        {
            table.Attach(Entity);
            _context.Entry(Entity).State = EntityState.Modified;
            _context.SaveChanges();
            return Entity;
        }

        #endregion

        #region Delete Function
        public TEntity Delete(Guid Id)
        {
            TEntity existing = table.Find(Id);
            table.Remove(existing);
            _context.SaveChanges();
            return existing;

        }

        public Task AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> condition = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null)
        {
            throw new NotImplementedException();
        }

        public string Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> condition = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null)
        {
            throw new NotImplementedException();
        }

        public string Removeobject(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> ExecuteStoreQueryAsync(string commandText, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> ExecuteStoreQueryAsync(string commandText, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null)
        {
            throw new NotImplementedException();
        }

        public TEntity AddId(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public string AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> ExecuteStoreQuery(string commandText, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> ExecuteStoreQuery(string commandText, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null)
        {
            throw new NotImplementedException();
        }

        public string Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<TEntity> entites)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}




