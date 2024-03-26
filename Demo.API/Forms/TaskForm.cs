using System.ComponentModel.DataAnnotations;

namespace Demo.API.Forms
{
    public class TaskForm
    {
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        public bool Important { get; set; }
    }
}
