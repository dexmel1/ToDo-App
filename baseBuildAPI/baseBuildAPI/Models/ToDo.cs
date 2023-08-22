using System.ComponentModel.DataAnnotations;

namespace basiBuildAPI.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        public string? ToDoName { get; set; }
    }
}
