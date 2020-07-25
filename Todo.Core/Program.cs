using System;

namespace Todo.Core
{
    using System.Linq;

    using Models;

    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            //var worker = manager.CreateWorker("Вася пупкин", "Крутой");
            var worker = manager.GetWorker("Крутой");

            manager.TaskAdd(worker, new Task() { Name = "Пинать хер" });
        }
    }

    class Manager
    {
        private TodoContext context = new TodoContext();

        public void SaveContext()
        {
            this.context.SaveChanges();
        }

        public Worker CreateWorker(string fullName, string login)
        {
            var worker = new Worker(fullName, login);
            this.context.Workers.Add(worker);
            this.context.SaveChanges();
            return worker;
        }

        public Worker GetWorker(string login) => this.context.Workers.FirstOrDefault(x => x.Login == login);

        public void TaskAdd(Worker worker, Task task)
        {
            worker.Tasks.Add(task);
            this.context.SaveChanges();
        }
    }
}
