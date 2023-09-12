using MongoDB.Bson;

namespace ToDoMongoDB.Model.Models
{
    public class ToDoList
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Datecreate { get; set; }
        public List<TaskModel> Tasks { get; set; }
    }
}
