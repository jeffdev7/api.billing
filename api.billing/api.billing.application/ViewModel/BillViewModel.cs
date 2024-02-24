using api.billing.domain.Entities;

namespace api.billing.application.ViewModel
{
    public record BillViewModel(string Id, 
        DateTime DueDate, 
        DateTime IssueDate, 
        decimal Price,
        bool IsCancelled, 
        Client Client, 
        ServiceProvider Provider);
}
