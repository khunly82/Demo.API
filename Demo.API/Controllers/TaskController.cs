using Demo.API.DTO;
using Demo.API.Forms;
using Demo.DAL.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController(TaskRepository taskRepository) : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            int id = int.Parse(User .FindFirst(ClaimTypes.NameIdentifier)?.Value);
            return Ok(taskRepository.GetByUser(id).Select(t => new TaskDTO
            {
                Id = id,
                Name = t.Name,
                Important = t.Important,
                IsComplete = t.IsComplete,
            }));
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] TaskForm form) 
        {
            int id = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            return Ok(taskRepository.Add(new DAL.Entities.Task
            {
                Name = form.Name,
                Important = form.Important,
                IsComplete = false,
                UserId = id
            }));
        }
    }
}
