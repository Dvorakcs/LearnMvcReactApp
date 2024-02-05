using System.ComponentModel.DataAnnotations;

namespace LearnMvcReactApp.Server.Models
{
    public class Produtos
    {
        [Key]
        public int Id { get; set; }
        public string? UrlImage { get; set; }
        public string? Nome { get; set; }
        public string? Descricao {  get; set; }
    }
}
