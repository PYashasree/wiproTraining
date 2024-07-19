using TaskApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskApi.Repository
{
  public interface ITaskRepository
  {
    Task<IEnumerable<Tasks>> GetAllTasks();
    Task<Tasks> GetTasks(int id);
    Task AddTasks(Tasks tasks);
    Task UpdateTasks(Tasks tasks);
    Task DeleteTasks(int id);

    Task<IEnumerable<SubTask>> GetAllSubtasks();
    Task<SubTask> GetSubTask(int id);
    Task AddSubTask(SubTask subTask);
    Task UpdateSubTask(SubTask subTask);
    Task DeleteSubTask(int id);
    Task<IEnumerable<SubTask>> GetSubTasksForTasks(int tasksId);
  }
}
