using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaQuiminvest.Model.Repositories
{
    public class RepositoryFuncionarios : IDisposable
    {
        private reatorEntities odb;
        private bool LiberaContexto = false;

        public RepositoryFuncionarios()
        {
            odb = Helper.Data.getContexto();
        }
        public RepositoryFuncionarios(reatorEntities _odb)
        {
            odb = _odb;
        }


        public funcionario Selecionar(string Codigo)
        {
            return (from p in odb.funcionario where p.Nome == Codigo select p).FirstOrDefault();
        }

        public List<funcionario> SelecionarTodos()

        {
            return (from p in odb.funcionario orderby p.Id select p).ToList();
        }

        public void Incluir(funcionario ofuncionarios)
        {
            odb.funcionario.Add(ofuncionarios);
            odb.SaveChanges();
        }

        public void Alterar(funcionario ofuncionarios, bool attach = false)
        {
            var local = odb.Set<funcionario>().Local.FirstOrDefault(p => p.Id == ofuncionarios.Id);
            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(ofuncionarios).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }
        public void Excluir(funcionario ofuncionarios)
        {
            odb.funcionario.Remove(ofuncionarios);
            //odb.Entry(oCadastroUsuario).State = System.Data.Entity.EntityState.Deleted;

            odb.SaveChanges();
        }

        public void Dispose()
        {
            if (LiberaContexto)
            {
                odb.Dispose();
            }
        }
    }
}
