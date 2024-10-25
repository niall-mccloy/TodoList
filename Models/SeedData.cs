using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoAppMvc.Data;
using System;
using System.Linq;

namespace TodoAppMvc.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new TodoAppContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<TodoAppContext>>()))
        {
            // Look for any movies.
            if (context.Todos.Any())
            {
                return;   // DB has been seeded
            }
            context.Todos.AddRange(
                new Todo
                {
                    Task = "Walk dog",
                    IsComplete = false
                },
                new Todo
                {
                    Task = "Walk rabbit",
                    IsComplete = false
                },
                new Todo
                {
                    Task = "Walk horse",
                    IsComplete = false
                },
                new Todo
                {
                    Task = "Walk cat",
                    IsComplete = false
                }
            );
            context.SaveChanges();
        }
    }
}