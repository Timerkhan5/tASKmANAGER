using System.Text.Json;
using tASKmANAGER;

public class TaskManager
{
    public TaskManager() { }

    public static List<TaskItem> Tasks = new List<TaskItem>();
    public static void addTask(TaskItem task)
    {
        Tasks.Add(task);
        saveTasks(Tasks);
    }
    public static void deleteTask(int id)
    {
        Tasks.RemoveAll(t => t.Id == id);
        saveTasks(Tasks);
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
    private static void saveTasks(List<TaskItem> tasks)
    {
        string json = JsonSerializer.Serialize(tasks);
        System.IO.File.WriteAllText("tasks.json", "");
        System.IO.File.WriteAllText("tasks.json", json);
    }


}
