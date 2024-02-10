namespace api.billing.domain.Entities
{
    public class Client : BaseEntity
    {
        public string Document { get; set; }
        public string Name { get; set; }

        public Client(string document, string name)
        {
            Document = document;
            Name = name;
        }
        public Client() { }
    }
}