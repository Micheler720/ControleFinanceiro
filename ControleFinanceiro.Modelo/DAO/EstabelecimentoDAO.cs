using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Modelo.Entidades;
using NHibernate.Transform;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using NHibernate.Criterion;

namespace ControleFinanceiro.Modelo.DAO
{
    public class EstabelecimentoDAO
    {

        private ISession session;

        public EstabelecimentoDAO(ISession session)
        {
            this.session = session;
        }
        public void Adiciona(Estabelecimento estabelecimento)
        {
            var transacao = session.BeginTransaction();
            session.Save(estabelecimento);
            transacao.Commit();

        }
        public void Alterar(Estabelecimento estabelecimento)
        {
            var transacao = session.BeginTransaction();
            session.Merge(estabelecimento);
            transacao.Commit();

        }
        public void Excluir(Estabelecimento estabelecimento)
        {
            var transacao = session.BeginTransaction();
            session.Delete(estabelecimento);
            transacao.Commit();

        }
        public Estabelecimento BuscarEstabelecimento(int id = 0, Tipo_Estabelecimento tipoEstabelecimento = null)
        {
            var crit = session.CreateCriteria("Estabelecimento");
            if(id != 0)
            {
                crit.Add(Restrictions.Eq("Id", id));
            }
            if(tipoEstabelecimento != null)
            {
                crit.Add(Restrictions.Eq("Tipo_Estabelecimento", tipoEstabelecimento));
            }
            return crit.SetMaxResults(1).UniqueResult<Estabelecimento>();
        }

        public List<Estabelecimento> BuscarEstabelecimentos()
        {
            var ListaEstabelecimentos = new List<Estabelecimento>();
            using (var tx = session.BeginTransaction())
            {
                var hql = "from Estabelecimento E order by E.Nome";
                IQuery query = session.CreateQuery(hql).SetCacheable(true);
                tx.Commit();
                ListaEstabelecimentos = (List<Estabelecimento>)query.List<Estabelecimento>();
                return ListaEstabelecimentos;
            }
        }
        public List<Estabelecimento> BuscarEstabelecimentoNome(string nome)
        {
            ICriteria criteria = session.CreateCriteria<Estabelecimento>();
            if(nome != "")
            {
                criteria = criteria.Add(Restrictions.Like("Nome",nome));
            }
           
            return (List<Estabelecimento>)criteria.List<Estabelecimento>();
        }
    }
}
