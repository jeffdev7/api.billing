using api.billing.domain.Entities;
using api.billing.domain.Repositories;
using MongoDB.Driver;

namespace api.billing.infra.Repositories
{
    public class BillRepository(IMongoDatabase mongoDatabase) : IBillRepository
    {
        private readonly Repository<Bill> _billRepository = new(mongoDatabase, "Bill");
        public void Add(Bill obj)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Bill> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Bill> GetByBillStatus(bool isCanceled)
        {
            throw new NotImplementedException();
        }

        public Task<Bill> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Bill GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Bill entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = entity.CreatedAt;
            return _billRepository.Insert(entity);
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task Update(Bill entity)
        {
            entity.UpdatedAt = DateTime.UtcNow;
            return _billRepository.Insert(entity);
        }
    }
}
