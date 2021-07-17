using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NewsApi.Models
{
    public class News
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
 
        public string title { get; set; }

        public string date { get; set; }

        public string details { get; set; }

        public string image { get; set; }
        public Comment[] comment { get; set; }
    }
}