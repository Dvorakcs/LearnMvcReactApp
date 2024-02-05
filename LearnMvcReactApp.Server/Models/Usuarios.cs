using System.ComponentModel.DataAnnotations;

namespace LearnMvcReactApp.Server.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
}
