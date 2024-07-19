using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;
using TaskApi.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubTaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public SubTaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet("Get")]
    public async Task<ActionResult<IEnumerable<SubTask>>> GetAllSubtasks()
    {
      return Ok(await _taskRepository.GetAllSubtasks());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SubTask>> GetSubTask(int id)
    {
      var subTask = await _taskRepository.GetSubTask(id);
      if (subTask == null)
      {
        return NotFound();
      }
      return Ok(subTask);
    }

    [HttpPost]
    public async Task<ActionResult<SubTask>> AddSubTask(SubTask subTask)
    {
      await _taskRepository.AddSubTask(subTask);
      return CreatedAtAction(nameof(GetSubTask), new { id = subTask.Id }, subTask);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSubTask(int id, SubTask subTask)
    {
      if (id != subTask.Id)
      {
        return BadRequest();
      }
      await _taskRepository.UpdateSubTask(subTask);
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSubTask(int id)
    {
      var subTask = await _taskRepository.GetSubTask(id);
      if (subTask == null)
      {
        return NotFound();
      }
      await _taskRepository.DeleteSubTask(id);
      return NoContent();
    }
  }
}
