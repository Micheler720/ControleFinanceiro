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
    public class FinPagarControle
    {
        public string Mensagem { get; private set; }
        public bool Sucesso = true;
        public void GravarSaida(Fin_Pagar saida)
        {
            var NegSaida = new FinPagarNegocio();
            if (NegSaida.ValidaSaidaNegocio(saida))
            {
                var session = NHibernateHelper.AbreSession();
                var dao = new FinPagarDAO(session);
                dao.Adiciona(saida);
                session.Close();
                Mensagem = "Dados Gravados com sucesso!";
            }            
        }
        public void ImportarSaida(List<Fin_Pagar> saidas, DateTime dataInicial, DateTime dataFinal)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new FinPagarDAO(session);
            dao.ExcluirImportado(dataInicial, dataFinal);
            dao.Adiciona(saidas);
            session.Close();
            Mensagem = "Contas a pagar importados com sucesso!\n";
        }
        public void AlterarSaida(Fin_Pagar saida)
        {
            var NegSaida = new FinPagarNegocio();
            if (NegSaida.ValidaSaidaNegocio(saida))
            {
                var session = NHibernateHelper.AbreSession();
                var dao = new FinPagarDAO(session);
                dao.Alterar(saida);
                session.Close();
                Mensagem = "Dados Alterados com sucesso!";
            }
        }
        public void ExcluirSaida(Fin_Pagar saida)
        {
            var NegSaida = new FinPagarNegocio();
            if (NegSaida.ValidaSaidaNegocio(saida))
            {
                var session = NHibernateHelper.AbreSession();
                var dao = new FinPagarDAO(session);
                dao.Excluir(saida);
                session.Close();
                Mensagem = "Dados excluido com sucesso!";
            }
        }
        public List<Fin_Pagar> BuscarFinanceiros()
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new FinPagarDAO(session);
            var lancamentos = dao.BuscarLancamentos();
            return lancamentos;
        }
        public Fin_Pagar BuscarFinanceiroId(int id)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new FinPagarDAO(session);
            var lancamentos = dao.BuscarLancamento(id:id);
            return lancamentos;
        }
        public List<Fin_Pagar> BuscaPorDataInclusao(DateTime dataInicial, DateTime dataFinal)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new FinPagarDAO(session);
            var lancamentos = dao.BuscarLancamentosDataInclusao(dataInicial, dataFinal);
            return lancamentos;
        }
        public List<Fin_Pagar> BuscaPorDataLancamento(DateTime dataInicial, DateTime dataFinal)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new FinPagarDAO(session);
            var lancamentos = dao.BuscarLancamentosDataLancamento(dataInicial, dataFinal);
            return lancamentos;
        }
        public List<RelAgrupadoPorData> BuscarLancamentosAgrupadaPorData(DateTime dataInicial, DateTime dataFinal)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new FinPagarDAO(session);
            var lancamentos = dao.BuscarLancamentosDataInclusaoAgrupadoPorData(dataInicial, dataFinal);
            return lancamentos;
        }
    }
}
