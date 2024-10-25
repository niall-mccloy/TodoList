using Microsoft.EntityFrameworkCore;
using TodoAppMvc.Models;

namespace TodoAppMvc.Data
{
    public class TodoAppContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public TodoAppContext(DbContextOptions<TodoAppContext> options)
            : base(options)
        {
        }
    }
}
