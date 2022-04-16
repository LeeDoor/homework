using System;

namespace learn
{
    public class Task
    {
        public string Condition { get; private set; }
        public string Name { get; private set; } // условие задачи и ее название
        public Func<bool> _solving; // ссылка на функцию с решением задачи

        public Task() { }
        public Task(string name, string condition, Func<bool> solving) : this()
        {
            Name = name;
            Condition = condition;
            _solving = solving;
        }

        public void ShowTask()
        {
            Console.WriteLine($"task: {Name}\n{Condition}");
            Console.WriteLine("\n\n");
            _solving();
        }
    }

    public class Homework
    {
        public string Date { get; set; }
        public List<Task> tasks;

        public Homework()
        {
            tasks = new List<Task>();
        }
        public Homework(string date) : this()
        {
            Date = date;
        }

        /// <summary>
        /// добавляет задачу в список
        /// </summary>
        /// <param name="name">название задачи</param>
        /// <param name="condition">условие задачи</param>
        /// <param name="solving">указатель на функцию с решением задачи</param>
        public void addTask(string name, string condition, Func<bool> solving)
        {
            tasks.Add(new Task(name, condition, solving));
        }


        /// <summary>
        /// отображает работу задачи
        /// </summary>
        /// <param name="name">имя задачи</param>
        public void showTask(string name)
        {
            foreach (Task task in tasks)
            {
                if (task.Name == name)
                {
                    task.ShowTask();
                    break;
                }
            }
        }
        /// <summary>
        /// отображает работу задачи
        /// </summary>
        /// <param name="id">номер задачи</param>
        public void showTask(int id)
        {
            if (0 <= id && id < tasks.Count)
            {
                tasks[id].ShowTask();
            }
        }


        /// <summary>
        /// показывает меню с выбором задачи
        /// </summary>
        public void showMenu()
        {
            Console.WriteLine("Список задач:\n-1 - выход");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i} - {tasks[i].Name}");
            }
        }


        /// <summary>
        /// функция запуска программы
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"{Date}\nСамощенко Леонид\nДобро пожаловать в мою домашнюю работу.\nвыберите номер задачи из списка:");
            while (true)
            {
                showMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == -1) return;
                showTask(choice);
                Console.WriteLine("нажмите клавишу чтобы продолжить...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

