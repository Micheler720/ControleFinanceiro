using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.DAO;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Excexoes;
using ControleFinanceiro.Modelo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Negocio
{
    internal class EstabelecimentoNegocio
    {
        public string Mensagem = "";
        internal bool ValidaCadastroEstabelecimento(Estabelecimento estabelecimento)
        {
            if(estabelecimento.Nome == "")
            {
                throw new EstabelecimentoException("Não é possivel inserir estabelecimento sem informação.");
            }

            return true;
        }
        internal bool ValidaExclusaoEstabelecimento(Estabelecimento estabelecimento)
        {
            var session = NHibernateHelper.AbreSession();
            var daoReceber = new FinReceberDAO(session);
            var lancamentoReceber = daoReceber.BuscarLancamento(estabelecimento: estabelecimento);
            var daoPagar = new FinPagarDAO(session);
            var lancamentoPagar = daoPagar.BuscarLancamento(estabelecimento: estabelecimento);
            session.Close();
            if (lancamentoReceber != null)
            {
                Mensagem += "Existem lançamentos no de entrada não é possível excluir estabelecimento.\n";
            }
            if (lancamentoPagar != null)
            {
                Mensagem += "Existem lançamentos no de saída não é possível excluir estabelecimento.\n";
            }
            
            if(Mensagem != "")
            {
                return false;
            }
            return true;
        }
    }
}
