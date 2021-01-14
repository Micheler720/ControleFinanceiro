using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Modelo;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.DAO
{
    public class FinPagarDAO
    {
        ISession session; 
        public FinPagarDAO(ISession session)
        {
            this.session = session;
        }
        public void Adiciona(Fin_Pagar fin)
        {
            var transacao = session.BeginTransaction();
            session.Save(fin);
            transacao.Commit();
        }
        public void Adiciona(List<Fin_Pagar> financeiros)
        {
            var transacao = session.BeginTransaction();
            foreach (var financeiro in financeiros)
            {
                session.Save(financeiro);
            }
            transacao.Commit();
        }
        public void Alterar(Fin_Pagar fin)
        {
            var transacao = session.BeginTransaction();
            session.Merge(fin);
            transacao.Commit();
        }
        public void Excluir(Fin_Pagar fin)
        {
            var transacao = session.BeginTransaction();
            session.Delete(fin);
            transacao.Commit();
        }
        public void ExcluirImportado(DateTime dataInicial, DateTime dataFinal)
        {
            var transacao = session.BeginTransaction();
            var hql = "delete Fin_Pagar f where f.Importado = 1 and f.Data_Lancamento between :dataInicial and :dataFinal";
            var query = session.CreateQuery(hql)
                .SetParameter("dataInicial", dataInicial)
                .SetParameter("dataFinal", dataFinal)
                .ExecuteUpdate();
            transacao.Commit();
        }
        public List<RelAgrupadoPorData> BuscarVendaAgrupadaPorDataPagamento(DateTime dataInicial,DateTime dataFinal)
        {
            var transacao = session.BeginTransaction();
            var hql = "sum(Valor) as Valor, Data_lancamento from Fin_Pagar f where f.Data_Pagamento between :dataInicial and :dataFinal group by f.Data_Lancamento";
            var query = session.CreateQuery(hql)
                .SetParameter("dataInicial", dataInicial)
                .SetParameter("dataFinal", dataFinal);
            var lancamentos = (List<RelAgrupadoPorData>)query.List<RelAgrupadoPorData>();
            transacao.Commit();
            return lancamentos;
        }
        public List<Fin_Pagar> BuscarLancamentos()
        {
            using (var transacao = session.BeginTransaction())
            {
                var hql = "from Fin_Pagar f join fetch f.Estabelecimento order by f.Estabelecimento.Nome";
                var query = session.CreateQuery(hql);
                transacao.Commit();
                List<Fin_Pagar> lancamentos = (List<Fin_Pagar>)query.List<Fin_Pagar>();
                return lancamentos;
            }            
        }

        public Fin_Pagar BuscarLancamento(int id = 0, Estabelecimento estabelecimento = null)
        {
           
                var lancamento = new Fin_Pagar();
                var crit = session.CreateCriteria("Fin_Pagar");
                if (estabelecimento != null)
                {
                    crit.Add(Restrictions.Eq("Estabelecimento", estabelecimento));
                }
                if (id != 0)
                {
                    crit.Add(Restrictions.Eq("Id", id));
                }
                lancamento = crit.SetMaxResults(1).UniqueResult<Fin_Pagar>();
                return lancamento;
        }
        public List<Fin_Pagar> BuscarLancamentosDataLancamento(DateTime dataInicial, DateTime dataFinal)
        {
            var lancamentos = new List<Fin_Pagar>();
            var crit = session.CreateCriteria("Fin_Pagar");
            crit.Add(Restrictions.Between("Data_Pagamento", dataInicial, dataFinal));
            lancamentos = (List<Fin_Pagar>)crit.List<Fin_Pagar>();
            return lancamentos;
        }
        public List<Fin_Pagar> BuscarLancamentosDataInclusao(DateTime dataInicial, DateTime dataFinal)
        {
            var lancamentos = new List<Fin_Pagar>();
            var crit = session.CreateCriteria("Fin_Pagar");
            crit.Add(Restrictions.Between("Data_Inclusao", dataInicial, dataFinal));
            lancamentos = (List<Fin_Pagar>)crit.List<Fin_Pagar>();
            return lancamentos;
        }
        public List<RelAgrupadoPorData> BuscarLancamentosDataInclusaoAgrupadoPorData(DateTime dataInicial, DateTime dataFinal)
        {
            using (var transacao = session.BeginTransaction())
            {
                var hql = $"select sum(f.Valor) as Valor, Data_Pagamento  as Data from Fin_Pagar f where f.Data_Pagamento between :dataInicial and :dataFinal group by f.Data_Pagamento";
                var query = session.CreateQuery(hql)
                .SetParameter("dataInicial", dataInicial)
                .SetParameter("dataFinal", dataFinal);
                transacao.Commit();
                var resultado = query.List<Object[]>();
                List<RelAgrupadoPorData> lancamentos = new List<RelAgrupadoPorData>();
                foreach (var linha in resultado)
                {
                    var dado = new RelAgrupadoPorData
                    {
                        Valor = (double)linha[0],
                        Data = (DateTime)linha[1]
                    };
                    lancamentos.Add(dado);
                }
                return lancamentos;
            }
        }
    }
}
