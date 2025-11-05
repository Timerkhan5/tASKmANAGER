using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tASKmANAGER
{
     public enum Status
    {
        ToDo,
        InProgress,
        Done
    }
     public class Task
    {
        public static int Id { get; set; }
        public string Description { get; set; }
        public Status TaskStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Task() { }
        public Task(string description)
        {
            Id++;
            Description = description;
            TaskStatus = Status.ToDo;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        public void updateDescription(string newDescription)
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
