using ProjetoIntegrador5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador5.Dao
{
    public class PrioridadeDao:DaoBase
    {
        public void Gravar(Prioridade objPrioridade)
        {
            banco.Prioridades.Add(objPrioridade);
            banco.SaveChanges();
        }
        public void Alterar(Prioridade objPrioridade)
        {
            var entry = banco.Entry(objPrioridade);
            banco.Set<Prioridade>().Attach(objPrioridade);
            entry.State = EntityState.Modified;
            banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            Prioridade Prioridade = Buscar(id);
            banco.Prioridades.Remove(Prioridade);
            banco.SaveChanges();

        }
        public IList<Prioridade> Buscar()

        {
            return banco.Prioridades.ToList();
        }

        public Prioridade Buscar(int id)
        {
            return banco.Prioridades.FirstOrDefault(a => a.PrioridadeID == id);
        }

    }
}