using ProjetoIntegrador5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador5.Dao
{
    public class StatusDao:DaoBase
    {

    public void Gravar(Status objStatus)
    {
        banco.Statuss.Add(objStatus);
        banco.SaveChanges();
    }
    public void Alterar(Status objStatus)
    {
        var entry = banco.Entry(objStatus);
        banco.Set<Status>().Attach(objStatus);
        entry.State = EntityState.Modified;
        banco.SaveChanges();
    }

    public void Excluir(int id)
    {
            Status Status = Buscar(id);
        banco.Statuss.Remove(Status);
        banco.SaveChanges();

    }
    public IList<Status> Buscar()

    {
        return banco.Statuss.ToList();
    }

    public Status Buscar(int id)
    {
        return banco.Statuss.FirstOrDefault(a => a.StatusID == id);
    }

}
}