
using ControleFinanceiro.Modelo.DAO;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Helpers;
using ControleFinanceiro.Modelo.Modelo;
using ControleFinanceiro.Modelo.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Controle
{
    public class FinReceberControle
    {
        public string Mensagem { get; private set; }
        public void GravarEntrada(Fin_Receber entrada)
        {
            var entradaNegocio = new EntradaNegocio();
            if (entradaNegocio.ValidaEntradaNegocio(entrada))
            {
                var session = NHibernateHelper.AbreSession();
                var dao = new FinReceberDAO(session);
                dao.Adiciona(entrada);
                session.Close();
                Mensagem = "Dados Gravados com sucesso!";
            }
        }
        public void ImportarEntrada(List<Fin_Receber> entradas, DateTime dataInicial, DateTime dataFinal)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new FinReceberDAO(session);
            dao.ExcluirImportado(dataInicial, dataFinal);
            dao.Adiciona(entradas);
            session.Close();
            Mensagem = "Contas a receber importado com sucesso!\n";
        }
        public void GerarParcelas(List<Fin_Receber> entradas, DateTime dataInicial, DateTime dataFinal)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new FinReceberDAO(session);
            dao.Adiciona(entradas);
            session.Close();
            Mensagem = "Contas a receber importado com sucesso!\n";
        }
        public void AlterarEntrada(Fin_Receber entrada)
        {
            var entradaNegocio = new EntradaNegocio();
            if (entradaNegocio.ValidaEntradaNegocio(entrada))
            {
                var session = NHibernateHelper.AbreSession();
                var dao = new FinReceberDAO(session);
                dao.Alterar(entrada);
                session.Close();
                Mensagem = "Dados Alterados com sucesso!";
            }
        }
        public void ExcluirEntrada(Fin_Receber entrada)
        {
            var entradaNegocio = new EntradaNegocio();
            if (entradaNegocio.ValidaEntradaNegocio(entrada))
            {
                var session = NHibernateHelper.AbreSession();
                var dao = new FinReceberDAO(session);
                dao.Excluir(entrada);
                session.Close();
                Mensagem = "Dados excluídos com sucesso!";
            }
        }
        public Fin_Receber BuscarFinanceiroId(int id)
        {          
            var session = NHibernateHelper.AbreSession();
            var dao = new FinReceberDAO(session);
            var finReceber = dao.BuscarLancamento(id:id);
            return finReceber;
        }
        public List<Fin_Receber> BuscarFinanceiros()
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new FinReceberDAO(session);
            var finReceber = dao.BuscarLancamentos();
            return finReceber;
        }
        public List<Fin_Receber> BuscaPorDataInclusao(DateTime dataInicial, DateTime dataFinal)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new FinReceberDAO(session);
            var lancamentos = dao.BuscarLancamentosDataInclusao(dataInicial, dataFinal);
            return lancamentos;
        }
        public List<Fin_Receber> BuscaPorDataLancamento(DateTime dataInicial, DateTime dataFinal)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new FinReceberDAO(session);
            var lancamentos = dao.BuscarLancamentosDataPagamento(dataInicial, dataFinal);
            return lancamentos;
        }
        public List<RelAgrupadoPorData> BuscarLancamentosAgrupadaPorData(DateTime dataInicial, DateTime dataFinal)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new FinReceberDAO(session);
            var lancamentos = dao.BuscarLancamentosDataInclusaoAgrupadoPorData(dataInicial, dataFinal);
            return lancamentos;
        }
    }
}
