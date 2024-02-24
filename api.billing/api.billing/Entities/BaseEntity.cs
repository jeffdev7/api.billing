using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace api.billing.domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
