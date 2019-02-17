using MongoDB.Bson.Serialization.Attributes;

namespace CrudMongoDB.Models
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Permissao { get; set; }
        public string Senha { get; set; }
    }
}