using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Modelo;
using NHibernate;
using NHibernate.Criterion;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.DAO
{
    public class FinReceberDAO
    {
        private ISession _session;
        public FinReceberDAO(ISession session)
        {
            _session = session;
        }
        public void Adiciona(Fin_Receber entrada)
        {
            var transacao = _session.BeginTransaction();
            _session.Save(entrada);
            transacao.Commit();
        }
        public void Adiciona(List<Fin_Receber> financeiros)
        {
            var transacao = _session.BeginTransaction();
            foreach (var financeiro in financeiros)
            {
                _session.Save(financeiro);
            }
            transacao.Commit();
        }
        public void Alterar(Fin_Receber entrada)
        {
            var transacao = _session.BeginTransaction();
            _session.Merge(entrada);
            transacao.Commit();
        }
        public void Excluir(Fin_Receber entrada)
        {
            var transacao = _session.BeginTransaction();
            _session.Delete(entrada);
            transacao.Commit();
        }
        public void ExcluirImportado(DateTime dataInicial, DateTime dataFinal)
        {
            var transacao = _session.BeginTransaction();
            var hql = "delete Fin_Receber f where f.Importado = 1 and f.Data_Lancamento between :dataInicial and :dataFinal";
            var query = _session.CreateQuery(hql)
                .SetParameter("dataInicial", dataInicial)
                .SetParameter("dataFinal", dataFinal)
                .ExecuteUpdate();
            transacao.Commit();
        }
        /// <summary>
        /// Busca de apenas um lancamento. Especificar nome do Parâmetro
        /// </summary>
        /// <param name="estabelecimento">Passar como Parâmetro Objeto Estabelecimento</param>
        /// <param name="id">Id do Lancamento</param>
        /// <returns></returns>
        public Fin_Receber BuscarLancamento(int id= 0,Estabelecimento estabelecimento = null)
        {
            var lancamento = new Fin_Receber();
            var crit = _session.CreateCriteria("Fin_Receber");
            if(estabelecimento != null)
            {
                crit.Add(Restrictions.Eq("Estabelecimento", estabelecimento));
            }  
            if(id != 0)
            {
               crit.Add(Restrictions.Eq("Id", id));
            }
            lancamento = crit.SetMaxResults(1).UniqueResult<Fin_Receber>(); 
            return lancamento;
        }
        public List<Fin_Receber> BuscarLancamentos()
        {
            using (var transacao = _session.BeginTransaction()){
                var hql = "from Fin_Receber e join fetch e.Estabelecimento order by e.Estabelecimento.Nome";
                var query = _session.CreateQuery(hql);
                transacao.Commit();
                List<Fin_Receber> ListaFinanceiros = (List<Fin_Receber>)query.List<Fin_Receber>();
                return ListaFinanceiros;
            }
        }

        public List<Fin_Receber> BuscarLancamentosDataPagamento(DateTime dataInicial, DateTime dataFinal)
        {
            var lancamentos = new List<Fin_Receber>();
            var crit = _session.CreateCriteria("Fin_Receber");
            crit.Add(Restrictions.Between("Data_Pagamento", dataInicial,dataFinal));
            lancamentos = (List<Fin_Receber>)crit.List<Fin_Receber>();
            return lancamentos;
        }
        public List<Fin_Receber> BuscarLancamentosDataInclusao(DateTime dataInicial, DateTime dataFinal)
        {
            var lancamentos = new List<Fin_Receber>();
            var crit = _session.CreateCriteria("Fin_Receber");
            crit.Add(Restrictions.Between("Data_Inclusao", dataInicial, dataFinal));
            lancamentos = (List<Fin_Receber>)crit.List<Fin_Receber>();
            return lancamentos;
        }
        public List<RelAgrupadoPorData> BuscarLancamentosDataInclusaoAgrupadoPorData(DateTime dataInicial, DateTime dataFinal)
        {
            using (var transacao = _session.BeginTransaction())
            {
                var hql = "select sum(f.Valor) as Valor, Data_Pagamento  as Data from Fin_Pagar f where f.Data_Pagamento between :dataInicial and :dataFinal group by f.Data_Pagamento";
                var query = _session.CreateQuery(hql)
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
