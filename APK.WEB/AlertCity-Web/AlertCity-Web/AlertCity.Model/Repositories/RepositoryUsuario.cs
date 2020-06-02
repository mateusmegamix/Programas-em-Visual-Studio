using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertCity.Model.Repositories
{
    public class RepositoryUsuario : IDisposable
    {
        private alextheodoroEntities _db;

        public RepositoryUsuario()
        {
            _db = new alextheodoroEntities();
        }

        public void Incluir(appCadastroUsuario oUsuario)
        {
            _db.appCadastroUsuario.Add(oUsuario);
            _db.SaveChanges();

        }

        public void Alterar(appCadastroUsuario oUsuario)
        {
            _db.Entry(oUsuario).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }

        public void Excluir(appCadastroUsuario oUsuario)
        {
            _db.Entry(oUsuario).State = System.Data.Entity.EntityState.Deleted;
            _db.SaveChanges();
        }

        public List<appCadastroUsuario> SelecionarTodos()
        {
            return (from p in _db.appCadastroUsuario orderby p.appLogin select p).ToList();
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public appCadastroUsuario Selecionar(int id)
        {
            return _db.appCadastroUsuario.Where(p => p.appLogin.Equals(id)).FirstOrDefault();
        }
    }
}