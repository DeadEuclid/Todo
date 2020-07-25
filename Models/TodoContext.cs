namespace Models
{
    using System.Data.Entity;

    public class TodoContext : DbContext
    {
        public TodoContext() : base("Server=localhost;Database=TodoDB;Trusted_Connection=True;")
        {
            this.Database.CommandTimeout = 300;
            this.Database.CreateIfNotExists();
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}