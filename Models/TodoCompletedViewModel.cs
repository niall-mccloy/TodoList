using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TodoAppMvc.Models;

public class TodoCompletedViewModel
{
    public List<Todo>? Todos {get; set;}
    public SelectList? IsCompleteds {get; set;}
    public string? IsCompleted {get; set;}
}