using ProjetoIntegrador5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador5.Dao
{
    public class ClienteDao : DaoBase
    {
        public void Gravar(Cliente objCliente)
        {
            banco.Clientes.Add(objCliente);
            banco.SaveChanges();
        }
        public void Alterar(Cliente objcliente)
        {
            var entry = banco.Entry(objcliente);
            banco.Set<Cliente>().Attach(objcliente);
            entry.State = EntityState.Modified;
            banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            Cliente cliente = Buscar(id);
            banco.Clientes.Remove(cliente);
            banco.SaveChanges();

        }
        public IList<Cliente> Buscar()

        {
            return banco.Clientes.ToList();
        }

        public Cliente Buscar(int id)
        {
            return banco.Clientes.FirstOrDefault(a => a.ClienteID == id);
        }

    }
}
   
