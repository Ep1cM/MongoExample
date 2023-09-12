namespace ToDoMongoDB.Model.Models
{
    public class TaskModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime Due { get; set; }
        public int Status { get; set; } = 0;
    }
}
