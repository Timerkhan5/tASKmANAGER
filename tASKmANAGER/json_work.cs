using System.Text.Json;
using tASKmANAGER;

public class TaskManager
{
    public TaskManager() { }

    public static List<TaskItem> Tasks = JsonSerializer.Deserialize<List<TaskItem>>(System.IO.File.ReadAllText("tasks.json")) ?? new List<TaskItem>();
    public static void addTask(TaskItem task)
    {
        Tasks.Add(task);
    }
    public static void deleteTask(int id)
    {
        Tasks.RemoveAll(t => t.Id == id);    }
    public static void getListTaskByStatus(Status status)
    {
        if (!System.IO.File.Exists("tasks.json"))
        {
            Console.WriteLine("There's no tasks :( ");
        }
        else
        {
            int i = 1;
            foreach (var t in Tasks.Where(t => t.TaskStatus == status))
            {
                if (t.TaskStatus == status)
                {
                    Console.WriteLine($"\n\n###\nTask {i}\n\nID: {t.Id}, Description: {t.Description}, Status: {t.TaskStatus}, Created At: {t.CreatedAt}, Updated At: {t.UpdatedAt}\n\n###");
                    i++;
                }
            }
        }
    }
    public static void getListOfTasks()
    {
        if (!System.IO.File.Exists("tasks.json"))
        {
            Console.WriteLine("There's no tasks :( ");
        }
        else
        {
            int i = 1;
            foreach (var t in Tasks)
            {
                Console.WriteLine($"\n\n###\nTask {i}\n\nID: {t.Id}, Description: {t.Description}, Status: {t.TaskStatus}, Created At: {t.CreatedAt}, Updated At: {t.UpdatedAt}\n\n###");
                i++;
            }
        }
    }
    public static  void saveTasks(List<TaskItem> tasks)
    {
        string json = JsonSerializer.Serialize(tasks);
        System.IO.File.WriteAllText("tasks.json", "");
        System.IO.File.WriteAllText("tasks.json", json);
    }


}
