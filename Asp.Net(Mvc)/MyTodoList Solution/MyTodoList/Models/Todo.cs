namespace MyTodoList.Models
{
    public class Todo
    {
        public int todoid { get; set; }
        
        public string name { get; set; }
        public bool isFinished { get; set; }
        public string? description { get; set; }
    }
}
