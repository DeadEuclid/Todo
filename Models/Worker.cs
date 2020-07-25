using System;


namespace Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public sealed class Worker
    {
        public Worker(string fullName, string login) : this()
        {
            this.FullName = fullName;
            this.Login = login;
        }
        public Worker()
        {
            this.Tasks = new List<Task>();
        }

        [Key]
        [Required]
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Login { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
