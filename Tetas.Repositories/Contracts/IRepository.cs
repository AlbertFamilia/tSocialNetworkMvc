﻿namespace Tetas.Repositories.Contracts
{
    using Domain.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IRepository<TEntity>
        where TEntity : class, IBaseEntity
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetByIdAsync(long id);

        Task CreateAsync(TEntity entity);
        Task<bool> ExistAsync(long id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<bool> DeleteAsync(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);
        bool Exists(long key);
        Task<TEntity> FindByIdAsync(long key);//will find by id and return the entity
        Task<List<TEntity>> FindByClause(Func<TEntity, bool> selector = null);
        Task<TEntity> GetByClause(Func<TEntity, bool> selector = null);
        //IQueryable<TEntity> GetAll();
        //Task<TEntity> GetById(int id);
        //Task Create(TEntity entity);
        //Task Update(int id, TEntity entity);
        //Task Delete(int id);
    }
}
