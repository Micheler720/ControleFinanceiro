using ControleFinanceiro.Modelo.Entidades;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.DAO
{
    internal class ValoresFixosDAO
    {
        private ISession session;

        internal ValoresFixosDAO(ISession session)
        {
            this.session = session;
        }
        internal void Adiciona(Valores_Fixos valor)
        {
            var transacao = session.BeginTransaction();
            session.Save(valor);
            transacao.Commit();
        }
        public void Alterar(Valores_Fixos valor)
        {
            var transacao = session.BeginTransaction();
            session.Merge(valor);
            transacao.Commit();
        }
        public void Excluir(Valores_Fixos valor)
        {
            var transacao = session.BeginTransaction();
            session.Delete(valor);
            transacao.Commit();
        }
        public List<List<string>> BuscarValoresFixos()
        {
            IList<Valores_Fixos> ListValoresFixos;
            var ListaValoresFixo = new List<List<string>>();
            using (var tx = session.BeginTransaction())
            {
                var hql = "from Valores_Fixos";
                IQuery query = session.CreateQuery(hql);
                ListValoresFixos = query.List<Valores_Fixos>();
                tx.Commit();
                foreach (var item in ListValoresFixos)
                {
                    ListaValoresFixo.Add(new List<string> { item.Id.ToString(), item.Nome });
                }
            }
            return ListaValoresFixo;
        }
        /// <summary>
        /// Busca por padrão Valores Fixos Ativos. Caso necessario inativos alterar parâmetro para 0.
        /// </summary>
        /// <param name="ativo">Status do Produto.</param>
        /// <returns></returns>
        public List<Valores_Fixos> BuscarValoresFixosAtivo(bool ativo = true)
        {
            var crit = session.CreateCriteria<Valores_Fixos>();
            crit = crit.Add(Restrictions.Eq("Ativo",ativo));            
            return (List<Valores_Fixos>)crit.List<Valores_Fixos>();
        }
        public Valores_Fixos BuscarValorFixoId(int id)
        {   
            return session.Get<Valores_Fixos>(id);
        }
    }
}
