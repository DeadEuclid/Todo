namespace Todo.Core
{
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
