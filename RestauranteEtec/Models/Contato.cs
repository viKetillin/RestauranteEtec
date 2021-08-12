using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteEtec.Models
{
    [Table("Contato")]
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataContato { get; set; }

        [Required]
        [StringLength(50)]
        public string NomePessoa { get; set; }

        [StringLength(100)]
        public string EmailPessoa { get; set; }

        [StringLength(100)]
        public string Assunto { get; set; }

        [StringLength(500)]
        public string Mensagem { get; set; }

        public int Status { get; set; }


        [StringLength(500)]
        public string Retorno { get; set; }
    }
}
