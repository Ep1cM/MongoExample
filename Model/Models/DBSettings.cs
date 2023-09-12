namespace ToDoMongoDB.Model.Models
{
    public class DBSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string ToDoCollectionName { get; set; } = null!;
    }
}
