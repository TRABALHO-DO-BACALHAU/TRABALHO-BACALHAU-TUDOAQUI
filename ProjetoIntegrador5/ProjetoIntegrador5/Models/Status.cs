using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador5.Models
{
    [Table("Status")]
    public class Status
    {
        public int StatusID { get; set; }

        [MaxLength(15)]
        [Column("Status", TypeName = "VARCHAR")]
       
        public string Statuss { get; set; }

        public ICollection<Compromisso> ListaCompromissos { get; set; }

    }
}