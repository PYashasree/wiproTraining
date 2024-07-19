namespace TaskApi.Models
{
  public class SubTask
  {
    public int Id { get; set; }
    public string SubTaskName { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string Description { get; set; }
    public int TasksId { get; set; }
    public Tasks Tasks { get; set; }
  }
}
