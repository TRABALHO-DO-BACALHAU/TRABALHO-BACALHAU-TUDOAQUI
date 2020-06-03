using ProjetoIntegrador5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador5.Context
{
    public class DataContext: DbContext

    {
        public DataContext() : base("DataContext")
        {

        }
        public virtual DbSet<Cliente> Clientes { get; set; }

        
    }
}