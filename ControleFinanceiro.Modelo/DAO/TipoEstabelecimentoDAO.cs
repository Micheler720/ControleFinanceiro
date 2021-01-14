using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Modelo.Entidades;
using NHibernate.Criterion;
using NHibernate.Loader.Criteria;

namespace ControleFinanceiro.Modelo.DAO.ConexaoMysql
{
    public class TipoEstabelecimentoDAO
    {
        private ISession session;

        public TipoEstabelecimentoDAO(ISession session)
        {
            this.session = session;
        }
        public void Adiciona(Tipo_Estabelecimento tipoEstabelecimento)
        {
            var transacao = session.BeginTransaction();
            session.Save(tipoEstabelecimento);
            transacao.Commit();

        }
        public void Alterar(Tipo_Estabelecimento tipoEstabelecimento)
        {
            var transacao = session.BeginTransaction();
            session.Merge(tipoEstabelecimento);
            transacao.Commit();

        }
        public Tipo_Estabelecimento BuscarPorId(int id)
        {
            return session.Get<Tipo_Estabelecimento>(id);

        }
        public Tipo_Estabelecimento BuscarTipoEstabelecimento(int id = 0, string descricao= "")
        {
            var crit = session.CreateCriteria("Tipo_Estabelecimento");
            if (id!=0)
            {
                crit.Add(Restrictions.Eq("Id", id));
            }
            if(descricao != "")
            {
                crit.Add(Restrictions.Eq("Descricao", descricao));
            }
            return crit.SetMaxResults(1).UniqueResult<Tipo_Estabelecimento>();
        }
        public Tipo_Estabelecimento BuscarTipoEstabelecimentoDescricao(int id = 0, string descricao = "")
        {
            var crit = session.CreateCriteria("Tipo_Estabelecimento");
            if (id != 0)
            {
                crit.Add(Expression.Disjunction()
                    .Add(Expression.Gt("Id",id))
                    .Add(Expression.Lt("Id",id))                    
                    );
            }
            if (descricao != "")
            {
                crit.Add(Restrictions.Eq("Descricao", descricao));
            }
            return crit.SetMaxResults(1).UniqueResult<Tipo_Estabelecimento>();
        }
        public List<List<string>> BuscarTipoEstabelecimento()
        {
            IList<Tipo_Estabelecimento> tiposEstabelecimentos;
            String hql = "from Tipo_Estabelecimento";
            var query = session.CreateQuery(hql);
            tiposEstabelecimentos = query.List<Tipo_Estabelecimento>();
            var ListaBusca = new List<List<string>>();
            foreach (var item in tiposEstabelecimentos)
            {
                ListaBusca.Add(new List<string> { item.Id.ToString(), item.Descricao });
            }
            return ListaBusca;
        }
        public void Excluir(Tipo_Estabelecimento estabelecimento)
        {
            var transacao = session.BeginTransaction();
            session.Delete(estabelecimento);
            transacao.Commit();
        }
    }
}
