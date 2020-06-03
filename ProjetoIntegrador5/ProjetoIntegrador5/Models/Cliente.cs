using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador5.Models
{
    [Table("Clientes")]
    public class Cliente
    {

            [Key]
            public int ClienteID { get; set; }

            [MaxLength(100)]
            [Column("Nome", TypeName = "VARCHAR")]
            [Required(ErrorMessage = "O campo nome e obrigatorio!!!")]
            public string Nome { get; set; }

            [MaxLength(15)]
            [Column("Telefone", TypeName = "VARCHAR")]
            public string Telefone { get; set; }

            [MaxLength(100)]
            [Display(Name = "Nome do Compromisso")]
             [Column("Nome Do Compromisso", TypeName = "VARCHAR")]
            public string NomeCompromisso { get; set; }

           [MaxLength(200)]
           [Column("Descrição", TypeName = "VARCHAR")]
           
           public string Descricao { get; set; }

            [Display(Name = "Data do Compromisso")]
            public DateTime CriacaoDoCompromisso { get; set; }

           [MaxLength(15)]
           [Column("Prioridade", TypeName = "VARCHAR")]
           public string Prioridade { get; set; }

           [Display(Name = "Compromisso Concluido?")]
           
           public  bool Status { get; set; }

    }
}