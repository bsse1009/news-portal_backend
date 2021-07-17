using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NewsApi.Models
{
    public class Comment
    {
        public string username { get; set; }

        public string time { get; set; }

        public string text { get; set; }
    }
}