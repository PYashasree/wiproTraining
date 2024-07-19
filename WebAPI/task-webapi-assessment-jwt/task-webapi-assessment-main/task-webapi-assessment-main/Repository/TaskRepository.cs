using Microsoft.EntityFrameworkCore;
using TaskApi.Models;
using TaskApi.TaskDbContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApi.Repository
{
  public class TaskRepository : ITaskRepository
  {
    private readonly DataDbContext _context;

    public TaskRepository(DataDbContext context)
    {
      _context = context;
    }

    public async Task<IEnumerable<Tasks>> GetAllTasks()
    {
      return await _context.Tasks.ToListAsync();
    }

    public async Task<Tasks> GetTasks(int id)
    {
      return await _context.Tasks.FindAsync(id);
    }

    public async Task AddTasks(Tasks tasks)
    {
                _context.Tasks.Add(tasks);
			await _context.SaveChangesAsync();
    }

    public async Task UpdateTasks(Tasks tasks)
    {
      _context.Entry(tasks).State = EntityState.Modified;
      await _context.SaveChangesAsync();
    }

    public async Task DeleteTasks(int id)
    {
      var tasks = await _context.Tasks.FindAsync(id);
      if (tasks != null)
      {
        _context.Tasks.Remove(tasks);
        await _context.SaveChangesAsync();
      }
    }

    public async Task<IEnumerable<SubTask>> GetAllSubtasks()
    {
      return await _context.SubTasks.ToListAsync();
    }

    public async Task<SubTask> GetSubTask(int id)
    {
      return await _context.SubTasks.FindAsync(id);
    }

    public async Task AddSubTask(SubTask subTask)
    {
      _context.SubTasks.Add(subTask);
      await _context.SaveChangesAsync();
    }

    public async Task UpdateSubTask(SubTask subTask)
    {
      _context.Entry(subTask).State = EntityState.Modified;
      await _context.SaveChangesAsync();
    }

    public async Task DeleteSubTask(int id)
    {
      var subTask = await _context.SubTasks.FindAsync(id);
      if (subTask != null)
      {
        _context.SubTasks.Remove(subTask);
        await _context.SaveChangesAsync();
      }
    }

    public async Task<IEnumerable<SubTask>> GetSubTasksForTasks(int tasksId)
    {
      return await _context.SubTasks.Where(st => st.TasksId == tasksId).ToListAsync();
    }
  }
}
