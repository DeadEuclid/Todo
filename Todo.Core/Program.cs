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
}
