using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDB.LOCADORA.MODEL.Repositories
{
    public class RepositoryVeiculo
    {
        private danielgomesEntities odb;

        public RepositoryVeiculo()
        {
            odb = Helper.Data.getContexto();
        }

        public RepositoryVeiculo(danielgomesEntities _odb)
        {
            odb = _odb;
        }
        public Veiculo Selecionar(int Codigo)
        {
            return (from p in odb.Veiculo where p.CodVeiculo == Codigo select p).FirstOrDefault();
        }

        public List<Veiculo> SelecionarTodos()
        {
            return (from p in odb.Veiculo orderby p.Modelo select p).ToList();
        }

        public void Incluir(Veiculo oVeiculo)
        {
            //odb.Entry(oVeiculo).State = System.Data.Entity.EntityState.Added;
            odb.Veiculo.Add(oVeiculo);
            odb.SaveChanges();
        }

        public void Alterar(Veiculo oVeiculo)
        {
            odb.Entry(oVeiculo).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void Excluir(Veiculo oVeiculo)
        {
            odb.Entry(oVeiculo).State = System.Data.Entity.EntityState.Deleted;
            odb.SaveChanges();
        }
    }
}
