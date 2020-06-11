using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador5.Models
{
    [Table("Prioridades")]
    public class Prioridade
    {
        [Key]
        public int PrioridadeID { get; set; }

        [MaxLength(15)]
        [Column("Prioridade", TypeName = "VARCHAR")]
        [Required(ErrorMessage = "A Prioridade e Obrigatoria!!")]
        public string Prioridades { get; set; }

        public ICollection<Prioridade> ListaPrioridade { get; set; }

    }
}