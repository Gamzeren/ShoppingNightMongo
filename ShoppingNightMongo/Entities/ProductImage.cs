using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingNightMongo.Entities
{
    public class ProductImage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductImageId { get; set; }


        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ImageUrl { get; set; }
    }
}
