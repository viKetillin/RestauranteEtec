using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteEtec.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome do produto")]
        [StringLength(50, ErrorMessage = "O nome deve possuir no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Por favor, informe a descrição do produto")]
        [StringLength(200, ErrorMessage = "A descrição deve possuir no máximo 50 caracteres")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Por favor, informe o preço do produto")]        
        public double Preco { get; set; }

        [StringLength(200)]
        public string Foto { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Por favor, informe a categoria do produto")]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        [Display(Name = "Destaque?")]
        public bool ExibirHome { get; set; }
    }
}
