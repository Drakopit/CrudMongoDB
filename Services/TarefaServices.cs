using System.Collections.Generic;
using System.Linq;
using CrudMongoDB.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace CrudMongoDB.Services
{
    public class TarefaService
    {
        private readonly IMongoCollection<Tarefa> _tarefas;

        public TarefaService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("Conexao"));
            var database = client.GetDatabase("Tarefa");
            _tarefas = database.GetCollection<Tarefa>("Tarefas");
        }

        public List<Tarefa> Get()
        {
            return _tarefas.Find(tarefa => true).ToList();
        }

        public Tarefa Get(string id)
        {
            return _tarefas.Find<Tarefa>(tarefa => tarefa.Id == id).FirstOrDefault();
        }

        public Tarefa Create(Tarefa tarefa)
        {
            _tarefas.InsertOne(tarefa);
            return tarefa;
        }

        public void Update(string id, Tarefa tarefaIn)
        {
            _tarefas.ReplaceOne(tarefa => tarefa.Id == id, tarefaIn);
        }

        public void Remove(Tarefa tarefaIn)
        {
            _tarefas.DeleteOne(tarefa => tarefa.Id == tarefaIn.Id);
        }

        public void Remove(string id)
        {
            _tarefas.DeleteOne(tarefa => tarefa.Id == id);
        }
    }
}