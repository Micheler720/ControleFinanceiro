using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.DAO;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Helpers;
using ControleFinanceiro.Negocio;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Controle
{
    public class EstabelecimentoControle
    {
        public string Mensagem;
        public bool Sucesso = true;
        public void GravarCadastroEstabelecimento(Estabelecimento estabelecimento)
        {

            var EstabelecimentoNegocio = new EstabelecimentoNegocio();
            if (EstabelecimentoNegocio.ValidaCadastroEstabelecimento(estabelecimento))
            {
                var session = NHibernateHelper.AbreSession();
                var estabelecimentoDAO = new EstabelecimentoDAO(session);
                estabelecimentoDAO.Adiciona(estabelecimento);
                session.Close();
                Mensagem = "Dados gravados com sucesso";
            } 
        }
        public void AlterarCadastroEstabelecimento(Estabelecimento estabelecimento)
        {

            var EstabelecimentoNegocio = new EstabelecimentoNegocio();
            if (EstabelecimentoNegocio.ValidaCadastroEstabelecimento(estabelecimento))
            {
                var session = NHibernateHelper.AbreSession();
                var estabelecimentoDAO = new EstabelecimentoDAO(session);
                estabelecimentoDAO.Alterar(estabelecimento);
                session.Close();
                Mensagem = "Dados alterados com sucesso";
            }
        }

        public void ExcluirCadastroEstabelecimento(Estabelecimento estabelecimento)
        {

            var EstabelecimentoNegocio = new EstabelecimentoNegocio();
            if (EstabelecimentoNegocio.ValidaExclusaoEstabelecimento(estabelecimento))
            {
                var session = NHibernateHelper.AbreSession();
                var estabelecimentoDAO = new EstabelecimentoDAO(session);
                estabelecimentoDAO.Excluir(estabelecimento);
                session.Close();
                Mensagem = "Dados excluídos com sucesso";
                Sucesso = true;
            }
            else
            {
                Sucesso= false;
                Mensagem = EstabelecimentoNegocio.Mensagem;
            }
        }
        public static Estabelecimento BuscarEstabelecimentoId(int id)
        {
            var session = NHibernateHelper.AbreSession();
            var estabelecimentoDAO = new EstabelecimentoDAO(session);
            var estabeleciemnto = estabelecimentoDAO.BuscarEstabelecimento(id:id);
            session.Close();
            return estabeleciemnto;
        }
        public List<Estabelecimento> BuscarEstabelecimento()
        {
            var session = NHibernateHelper.AbreSession();
            var estabelecimentoDAO = new EstabelecimentoDAO(session);
            var estabeleciemntos = estabelecimentoDAO.BuscarEstabelecimentos();
            //Console.WriteLine(estabeleciemntos[0].Nome);
            session.Close();
            return estabeleciemntos;
        }
        public List<Estabelecimento> BuscarEstabelecimentoNome(string nome)
        {
            var session = NHibernateHelper.AbreSession();
            var estabelecimentoDAO = new EstabelecimentoDAO(session);
            var estabeleciemntos = estabelecimentoDAO.BuscarEstabelecimentoNome(nome);
            session.Close();
            return estabeleciemntos;
        }
    }
}
