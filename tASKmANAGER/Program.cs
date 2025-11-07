namespace tASKmANAGER
{
    public class Program
    {
        static void Main(string[] args)
        {
            string help = "You can add task,remove task ,get list tasks (optionaly by status). " +
                "To add task write 'add '\n," +
                "to remove task enter 'remove '," +
                "\nto get list of tasks enter 'get_list'," +
                "\nto get list by status enter 'get_list_by_status'," +
                "\nto change task description enter  'update_desc', " +
                "\nto change task status enter 'update_status.'" +
                "\nIf you want to save your tasks in json file , you should enter 'save'  " +
                "\nYou can call help any time you want :) " +
                "\nTo exit programm use exit";
            Console.WriteLine("Welcome to Task Manager by Timerkhan Kurtashkin!\n\n" + help);
            int id;
            if (TaskManager.Tasks.Count == 0)
            {
                id = 0;
            }
            else
            {
                id = TaskManager.Tasks.Max(t => t.Id);
            }
            string? command = Console.ReadLine();
            while (command != "exit")
            {
                if (command == "help")
                {
                    Console.WriteLine(help);
                    command = Console.ReadLine();
                }
               else  if (command == "add")
                {
                    Console.WriteLine("Enter task description : ");
                    string? description = Console.ReadLine();
                    TaskItem task = new TaskItem(description, id);
                    TaskManager.addTask(task);
                    id++;
                    Console.WriteLine("\n\nTask added sucessfully!\nNext command");
                    command = Console.ReadLine();
                }
                else if (command == "remove")
                {
                    Console.WriteLine("Enter task ID to remove : ");
                    int removeId = Convert.ToInt32(Console.ReadLine());
                    TaskManager.deleteTask(removeId);
                    Console.WriteLine("\n\nTask remove sucessfully!\nNext command");
                    command = Console.ReadLine();

                }
                else if (command == "get_list")
                {
                    Console.WriteLine("\nThere's full list of tasks :)");
                    TaskManager.getListOfTasks();
                    Console.WriteLine("\nNext command ,please )");
                    command = Console.ReadLine();

                }
                else if (command == "get_list_by")
                {
                    Console.WriteLine("Enter status (ToDo, InProgress, Done) : ");
                    string? statusInput = Console.ReadLine();
                    if (Enum.TryParse<Status>(statusInput, out Status status))
                    {
                        Console.WriteLine("\nThere's list of tasks filtered by status :) ");

                        TaskManager.getListTaskByStatus(status);
                    }
                    else
                    {
                        Console.WriteLine("Invalid status entered.");
                    }
                    Console.WriteLine("\nNext command ,please )");
                    command = Console.ReadLine();
                }
                else if (command == "update_desc")
                {
                    Console.WriteLine("Enter task ID to update description : ");
                    int updateId = Convert.ToInt32(Console.ReadLine());
                    var taskToUpdate = TaskManager.Tasks.FirstOrDefault(t => t.Id == updateId);
                    if (taskToUpdate != null)
                    {
                        Console.WriteLine("Enter new description : ");
                        string? newDescription = Console.ReadLine();
                        taskToUpdate.updateDescription(newDescription);
                        Console.WriteLine("\n\nTask description updated sucessfully!\nNext command");
                        command = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Task not found.\nNext command");
                        command = Console.ReadLine();
                    }
                }
                else if (command == "update_status")
                {
                    Console.WriteLine("Enter task ID to update status : ");
                    int updateId = Convert.ToInt32(Console.ReadLine());
                    var taskToUpdate = TaskManager.Tasks.FirstOrDefault(t => t.Id == updateId);
                    if (taskToUpdate != null)
                    {
                        Console.WriteLine("Enter new status (ToDo, InProgress, Done) : ");
                        string? statusInput = Console.ReadLine();
                        if (Enum.TryParse<Status>(statusInput, out Status newStatus))
                        {
                            taskToUpdate.updateStatus(newStatus);
                            Console.WriteLine("\n\nTask status updated sucessfully!\nNext command");
                            command = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Invalid status entered.\nNext command");
                            command = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Task not found.\nNext command");
                    }
                }
                else if (command == "save")
                {
                    TaskManager.saveTasks(TaskManager.Tasks);
                }
                else
                {
                    Console.WriteLine("Unknown command. Type 'help' for available commands.");
                    command = Console.ReadLine();
                }
            }
        }
    }
}