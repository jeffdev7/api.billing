namespace api.billing.domain.Entities
{
    public class Bill : BaseEntity
    {
        public DateTime DueDate { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal Price { get; set; }
        public bool IsCancelled { get; set; } = false;
        public Client Client { get; set; }
        public ServiceProvider Provider { get; set; }

        public Bill() { }

        public Bill(DateTime dueDate, DateTime issueDate, decimal price,
            bool isCancelled, Client client, ServiceProvider provider)
        {
            DueDate = dueDate;
            IssueDate = issueDate;
            Price = price;
            IsCancelled = isCancelled;
            Client = client;
            Provider = provider;
        }

        public static Bill Create(DateTime dueDate, DateTime issueDate,
            decimal price, bool isCancelled,
            Client client, ServiceProvider provider) =>
            new()
            {
                DueDate = dueDate,
                IssueDate = issueDate,
                Price = price,
                IsCancelled = isCancelled,
                Client = client,
                Provider = provider
            };
    }
}
