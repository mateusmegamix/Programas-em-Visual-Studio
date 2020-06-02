using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertCity.Model.Repositories
{
    public class RepositoryBuraco : IDisposable
    {
        private alextheodoroEntities _db;

        public RepositoryBuraco()
        {
            _db = new alextheodoroEntities();
        }

        public void Incluir(BuracoReg oBuraco)
        {
            _db.BuracoReg.Add(oBuraco);
            _db.SaveChanges();
              
        }

        public void Alterar(BuracoReg oBuraco)
        {
            _db.Entry(oBuraco).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }

        public void Excluir(BuracoReg oBuraco)
        {
            _db.Entry(oBuraco).State = System.Data.Entity.EntityState.Deleted;
            _db.SaveChanges();
        }

        public List<BuracoReg> SelecionarTodos()
        {
            return (from p in _db.BuracoReg orderby p.RegistroBuraco select p).ToList();
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public BuracoReg Selecionar(int id)
        {
            return _db.BuracoReg.Where(p => p.RegistroBuraco.Equals(id)).FirstOrDefault();
        }
    }
}
