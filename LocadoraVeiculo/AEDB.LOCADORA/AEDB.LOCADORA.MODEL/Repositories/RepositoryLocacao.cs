using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDB.LOCADORA.MODEL.Repositories
{
    public class RepositoryLocacao
    {
        private danielgomesEntities odb;

        public RepositoryLocacao()
        {
            odb = Helper.Data.getContexto();
        }

        public RepositoryLocacao(danielgomesEntities _odb)
        {
            odb = _odb;
        }

        public Locacao Selecionar(int Codigo)
        {
            return (from p in odb.Locacao where p.CodLoc == Codigo select p).FirstOrDefault();
        }

        public List<Locacao> SelecionarTodos()
        {
            return (from p in odb.Locacao orderby p.CodF select p).ToList();
        }

        public void Incluir(Locacao oLocacao)
        {
            //odb.Entry(oLocacao).State = System.Data.Entity.EntityState.Added;
            odb.Locacao.Add(oLocacao);
            odb.SaveChanges();
        }

        public void Alterar(Locacao oLocacao)
        {
            odb.Entry(oLocacao).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void Excluir(Locacao oLocacao)
        {
            odb.Entry(oLocacao).State = System.Data.Entity.EntityState.Deleted;
            odb.SaveChanges();
        }

    }
}
