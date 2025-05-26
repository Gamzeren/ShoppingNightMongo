using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingNightMongo.Entities
{
    public class Slider
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String SliderId { get; set; }
        public String Title { get; set; }
        public String SubTitle { get; set; }
        public String ImageUrl { get; set; }
    }
}
