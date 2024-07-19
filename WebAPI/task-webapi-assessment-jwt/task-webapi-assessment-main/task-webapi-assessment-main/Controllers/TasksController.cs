using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;
using TaskApi.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public TasksController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tasks>>> GetAllTasks()
        {
            return Ok(await _taskRepository.GetAllTasks());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tasks>> GetTasks(int id)
        {
            var tasks = await _taskRepository.GetTasks(id);
            if (tasks == null)
            {
                return NotFound();
            }
            return Ok(tasks);
        }

        [HttpPost]
        public async Task<ActionResult<Tasks>> AddTasks([FromBody] Tasks tasks)
    {
      await _taskRepository.AddTasks(tasks);
      return CreatedAtAction(nameof(GetTasks), new { id = tasks.Id }, tasks);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTasks(int id, Tasks tasks)
    {
      if (id != tasks.Id)
      {
        return BadRequest();
      }
      await _taskRepository.UpdateTasks(tasks);
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTasks(int id)
    {
      var tasks = await _taskRepository.GetTasks(id);
      if (tasks == null)
      {
        return NotFound();
      }
      await _taskRepository.DeleteTasks(id);
      return NoContent();
    }
  }
}
