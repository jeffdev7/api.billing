﻿using api.billing.domain.Entities;

namespace api.billing.domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        //  void Update(TEntity obj);
        void Remove(Guid id);
        int SaveChanges();
        Task Insert(Bill entity);
    }
}
