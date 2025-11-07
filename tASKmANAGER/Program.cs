namespace tASKmANAGER
{
    public class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            int id = 0;
            TaskItem task1 = new TaskItem("Watching Interstellar",id);
            id++;
            TaskItem task2 = new TaskItem("Reading",id);
            id++;
            TaskManager.addTask(task1);
            TaskManager.addTask(task2);
            Console.WriteLine("\n\nAll tasks\n\n");
            TaskManager.getListOfTasks();
            task2.updateStatus(Status.InProgress);
            Console.WriteLine("\n\nAll tasks in progress\n\n");
            TaskManager.getListTaskByStatus(Status.InProgress);
        }
    }
}