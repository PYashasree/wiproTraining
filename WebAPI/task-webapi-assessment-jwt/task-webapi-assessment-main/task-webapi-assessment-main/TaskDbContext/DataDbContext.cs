using Microsoft.EntityFrameworkCore;
using TaskApi.Models;

namespace TaskApi.TaskDbContext
{
  public class DataDbContext : DbContext
  {
    public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

    public DbSet<Tasks> Tasks { get; set; }
    public DbSet<SubTask> SubTasks { get; set; }
	public DbSet<User> User { get; set; }
	}
}
