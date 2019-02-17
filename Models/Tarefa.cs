using MongoDB.Bson.Serialization.Attributes;

namespace CrudMongoDB.Models
{
    public class Tarefa
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Titulo { get; set; }
    }
}