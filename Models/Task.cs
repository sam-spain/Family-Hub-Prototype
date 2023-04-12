using System.ComponentModel.DataAnnotations;

namespace family_hub_prototype.Models;

public class Task
{
    public int Id { get; set; }
    public string? TaskName { get; set; }
    [DataType(DataType.Date)]
    public DateTime TaskDueDate { get; set; }
    public int TaskAssigneeId { get; set; }
    public bool TaskIsCompleted { get; set; }
    public DateTime TaskCompletedDate { get; set; }
}