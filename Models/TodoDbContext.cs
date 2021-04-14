using Microsoft.EntityFrameworkCore;
using TodoWebAPI.Models.Todo;

namespace TodoWebAPI.Models
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> opt) : base(opt)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Person> People { get; set; }

    }
}