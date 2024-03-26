namespace Demo.DAL.Repositories
{
    public class TaskRepository(DemoContext context)
    {
        public IEnumerable<Entities.Task> GetByUser(int userId)
        {
            return context.Tasks.Where(t => t.UserId == userId);
        }

        public Entities.Task Add(Entities.Task task)
        {
            Entities.Task t =  context.Tasks.Add(task).Entity;
            context.SaveChanges();
            return t;
        }
    }
}
