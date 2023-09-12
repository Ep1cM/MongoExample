using ToDoMongoDB.Model.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace ToDoMongoDB.Model.Repo
{
    public class ToDoListRepo 
    {
        private readonly IMongoCollection<ToDoList> _todoCollection;

        public ToDoListRepo(
            IOptions<DBSettings> bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                bookStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                bookStoreDatabaseSettings.Value.DatabaseName);  

            _todoCollection = mongoDatabase.GetCollection<ToDoList>(
                bookStoreDatabaseSettings.Value.ToDoCollectionName);
        }
        public async Task<List<ToDoList>> GetAsync() =>
            await _todoCollection.Find(_ => true).ToListAsync();

        public async Task<ToDoList?> GetAsync(string id) =>
            await _todoCollection.Find(x => x.Id.ToString() == id).FirstOrDefaultAsync();

        public async Task CreateAsync(ToDoList newToDoList) =>
            await _todoCollection.InsertOneAsync(newToDoList);

        public async Task UpdateAsync(string id, ToDoList updatedToDoList) =>
            await _todoCollection.ReplaceOneAsync(x => x.Id.ToString() == id, updatedToDoList);

        public async Task RemoveAsync(string id) =>
            await _todoCollection.DeleteOneAsync(x => x.Id.ToString() == id);
    }
}