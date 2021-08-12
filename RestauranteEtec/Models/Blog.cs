using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteEtec.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Titulo{ get; set; }

        [StringLength(1000)]
        public string Texto { get; set; }

        public DateTime DataCadastro { get; set; }

        [StringLength(200)]
        public string Foto { get; set; }
    }
}
