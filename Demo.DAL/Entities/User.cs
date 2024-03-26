namespace Demo.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public ICollection<Task> Tasks { get; set; } = null!;
    }
}
