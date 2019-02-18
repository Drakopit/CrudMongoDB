using MongoDB.Bson.Serialization.Attributes;

namespace CrudMongoDB.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
    }
}