using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertCity.Model.Repositories
{
    public class RepositoryEvento : IDisposable
    {
        private alextheodoroEntities _db;

        public RepositoryEvento()
        {
            _db = new alextheodoroEntities();
        }

        public void Incluir(Evento oEvento)
        {
            _db.Evento.Add(oEvento);
            _db.SaveChanges();

        }

        public void Alterar(Evento oEvento)
        {
            _db.Entry(oEvento).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }

        public void Excluir(Evento oEvento)
        {
            _db.Entry(oEvento).State = System.Data.Entity.EntityState.Deleted;
            _db.SaveChanges();
        }

        public List<Evento> SelecionarTodos()
        {
            return (from p in _db.Evento orderby p.RegistroEvento select p).ToList();
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public Evento Selecionar(int id)
        {
            return _db.Evento.Where(p => p.RegistroEvento.Equals(id)).FirstOrDefault();
        }
    }
}
