using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoAppMvc.Models
{
    public class Todo
    {
        public int Id {get; set;}
        public string Task {get; set;}

        [Display(Name = "Complete")]
        public bool IsComplete {get; set;}
        public DateTime? DueDate {get; set;}
    }
}