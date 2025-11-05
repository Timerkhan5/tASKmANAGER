using System.Text.Json;
void addTask(Task task)
{
    using (FileStream fs = new FileStream("tasks.json", FileMode.Append, FileAccess.Write))
    {
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        JsonSerializer.Serialize(fs, task, options);
    }
}
void deleteTask(int taskId)
{
    var tasks = new List<Task>();
    using (FileStream fs = new FileStream("tasks.json", FileMode.Open, FileAccess.Read))
    {
        tasks = JsonSerializer.Deserialize<List<Task>>(fs);
    }
    tasks.RemoveAll(t => t.Id == taskId);
    using (FileStream fs = new FileStream("tasks.json", FileMode.Create, FileAccess.Write))
    {
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        JsonSerializer.Serialize(fs, tasks, options);
    }
}
List<Task> getAllTasks()
{
    using (FileStream fs = new FileStream("tasks.json", FileMode.Open, FileAccess.Read))
    {
        return JsonSerializer.Deserialize<List<Task>>(fs);
    }
}
