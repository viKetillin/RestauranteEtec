using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteEtec.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }
        [Required]
        [Range(0.01, 1000)]
        public double Preco { get; set; }
        [StringLength(200)]
        public string Foto { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public bool ExibirHome { get; set; }
    }
}
