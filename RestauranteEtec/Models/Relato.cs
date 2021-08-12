using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteEtec.Models
{
    [Table("Relato")]
    public class Relato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Texto { get; set; }
        
        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(30)]
        public string TipoPessoa { get; set; }

        [StringLength(200)]
        public string FotoPessoa { get; set; }

        public bool ExibirHome { get; set; }
    }
}
