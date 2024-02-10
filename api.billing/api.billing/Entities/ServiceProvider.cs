namespace api.billing.domain.Entities
{
    public class ServiceProvider: BaseEntity
    {
        public string Document { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ServiceProvider(string document, string name, string address)
        {
            Document = document;
            Name = name;
            Address = address;
        }
        public ServiceProvider(){}
    }
}