using api.billing.domain.Entities;

namespace api.billing.domain.Repositories
{
    public interface IBillRepository : IRepository<Bill>
    {
        Task Insert(Bill entity);
        Task Update(Bill entity);
        Task<Bill> GetById(string id);
        Task<Bill> GetByBillStatus(bool isCanceled);
    }
}
