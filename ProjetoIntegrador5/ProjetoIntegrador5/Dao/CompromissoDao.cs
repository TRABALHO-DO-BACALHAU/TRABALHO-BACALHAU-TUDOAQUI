using ProjetoIntegrador5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador5.Dao
{
    public class CompromissoDao: DaoBase
    {

        
        public void Gravar(Compromisso objCompromisso)
        {
            banco.Compromissos.Add(objCompromisso);
            banco.SaveChanges();
        }
        public void Alterar(Compromisso objCompromisso)
        {
            var entry = banco.Entry(objCompromisso);
            banco.Set<Compromisso>().Attach(objCompromisso);
            entry.State = EntityState.Modified;
            banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            Compromisso compromisso = Buscar(id);
            banco.Compromissos.Remove(compromisso);
            banco.SaveChanges();

        }
        public IList<Compromisso> Buscar()

        {
            return banco.Compromissos.ToList();
        }

        public Compromisso Buscar(int id)
        {
            return banco.Compromissos.FirstOrDefault(a => a.CompromissoID == id);
        }

    }
}
