using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDB.LOCADORA.MODEL.Repositories
{
    public class RepositoryFuncionario
    {
        private danielgomesEntities odb;

        public RepositoryFuncionario()
        {
            odb = Helper.Data.getContexto();
        }

        public RepositoryFuncionario(danielgomesEntities _odb)
        {
            odb = _odb;
        }

        public Funcionario Selecionar(int Codigo)
        {
            return (from p in odb.Funcionario where p.CodFunc == Codigo select p).FirstOrDefault();
        }

        public List<Funcionario> SelecionarTodos()
        {
            return (from p in odb.Funcionario orderby p.NomeFunc select p).ToList();
        }

        public void Incluir(Funcionario oFuncionario)
        {
            //odb.Entry(oFuncionario).State = System.Data.Entity.EntityState.Added;
            odb.Funcionario.Add(oFuncionario);
            odb.SaveChanges();
        }

        public void Alterar(Funcionario oFuncionario)
        {
            odb.Entry(oFuncionario).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void Excluir(Funcionario oFuncionario)
        {
            odb.Entry(oFuncionario).State = System.Data.Entity.EntityState.Deleted;
            odb.SaveChanges();
        }
    }
}
