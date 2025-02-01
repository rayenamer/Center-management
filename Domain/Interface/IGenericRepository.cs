using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        #region async Functions
        //Task AddAsync(TEntity entity);
        //Task AddRangeAsync(IEnumerable<TEntity> entities);
        //Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> condition = null,
        //    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);
        //string Update(TEntity entity);
        //TEntity Put(TEntity entity);
        //Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> condition = null,
        //    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);
        //TEntity  Delete(Guid id);
        //string Removeobject(TEntity entity);
        //IEnumerable<TEntity>GetByID(Guid id);
        //TEntity  GetById(Guid id);

        //IEnumerable<TEntity>ExecuteStoreQueryAsync(String commandText, params object[] parameters);
        //IEnumerable<TEntity>ExecuteStoreQueryAsync(String commandText, Func<IQueryable<TEntity>,
        //    IIncludableQueryable<TEntity, object>> includes = null);

        //#endregion

        //#region sync Functions

        //TEntity  Add(TEntity entity);
        //TEntity  AddId(TEntity entity);
        //string AddRange(IEnumerable<TEntity>entities);

        //TEntity Get(Expression<Func<TEntity, bool>> condition = null,
        //    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);

        //IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> condition = null,
        //    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);

        //IEnumerable<TEntity> ExecuteStoreQuery(String commandText, params object[] parameters);

        //IEnumerable<TEntity> ExecuteStoreQuery(String commandText,
        //    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);

        //string Remove(Guid id);
        //void RemoveRange(IEnumerable<TEntity> entites);
        #endregion

        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> condition,
           Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);

        TEntity Get(Expression<Func<TEntity, bool>> condition,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);

        TEntity Add(TEntity entity);

        TEntity Delete(Guid id);

        TEntity Put(TEntity entity);
    }
}
