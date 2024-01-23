namespace TodoAPI.Model
{
	public class Todo
	{
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime CreatedDate { get; set;} = DateTime.Now;
        public bool IsFinished { get; set; } = false;
    }
}
