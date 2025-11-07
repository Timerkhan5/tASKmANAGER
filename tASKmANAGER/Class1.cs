namespace tASKmANAGER
{
    public enum Status
    {
        ToDo,
        InProgress,
        Done
    }
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public Status TaskStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public TaskItem() { }
        public TaskItem(string? description,int id)
        {
            Id = id+1;
            Description = description;
            TaskStatus = Status.ToDo;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        public void updateDescription(string? newDescription)
        {
            Description = newDescription;
            UpdatedAt = DateTime.Now;
        }
        public void updateStatus(Status newStatus)
        {
            TaskStatus = newStatus;
            UpdatedAt = DateTime.Now;
        }
    }
}
