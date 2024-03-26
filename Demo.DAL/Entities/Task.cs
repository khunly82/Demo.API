namespace Demo.DAL.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Important { get; set; }
        public bool IsComplete { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
