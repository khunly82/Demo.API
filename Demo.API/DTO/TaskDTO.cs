namespace Demo.API.DTO
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Important { get; set; }
        public bool IsComplete { get; set; }
    }
}
