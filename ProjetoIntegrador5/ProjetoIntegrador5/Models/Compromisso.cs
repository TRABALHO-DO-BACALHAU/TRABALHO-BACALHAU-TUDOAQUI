using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador5.Models
{
    [Table("Compromissos")]
    public class Compromisso
    {   
        [Key]
        public int CompromissoID { get; set; }

        [MaxLength(100)]
        [Column("Nome do Compromisso", TypeName = "VARCHAR")]
        [Required(ErrorMessage = "O campo nome e obrigatorio!!")]
        public string Nome { get; set; }


        [MaxLength(200)]
        [Column("Compromisso", TypeName = "VARCHAR")]
        public string Compromissos { get; set; }

        public Cliente objCliente { get; set; }

        public Prioridade objPrioridade { get; set; }

        public Status objStatus { get; set; }

    }
}