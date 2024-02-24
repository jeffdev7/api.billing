using api.billing.domain.Entities;
using api.billing.domain.Repositories;
using MongoDB.Driver;

namespace api.billing.infra.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public Repository(IMongoDatabase mongoClient, string name)
        {
        }
        public Task Insert(Bill entity)
        {
            throw new NotImplementedException();

        }

        public void Add(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
