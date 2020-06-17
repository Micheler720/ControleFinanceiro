using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.DAO.ConexaoMysql;
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
    public class TipoEstabelecimentoControle
    {
        public bool Status = true;
        public string Mensagem;
        public void GravarTipoEstabelecimento(Tipo_Estabelecimento tipoEstabelecimento)
        {
            var tipoEstabelecimentoNegocio = new TipoEstabelecimentoNegocio();   
            if (tipoEstabelecimentoNegocio.validaTipoEstabelecimentoNegocio(tipoEstabelecimento))
            {
                ISession session = NHibernateHelper.AbreSession();                
                var tipoEstabelecimentoDAO = new TipoEstabelecimentoDAO(session);
                tipoEstabelecimentoDAO.Adiciona(tipoEstabelecimento);
                session.Close();
                Mensagem = "Dados Gravados com sucesso!"; 
                Status = true;
            }
            else
            {
                Status = false;
                Mensagem = tipoEstabelecimentoNegocio.Mensagem;
            }
        }
        public void AlterarTipoEstabelecimento(Tipo_Estabelecimento tipoEstabelecimento)
        {
            var tipoEstabelecimentoNegocio = new TipoEstabelecimentoNegocio();
            if (tipoEstabelecimentoNegocio.validaAlteracao(tipoEstabelecimento))
            {
                ISession session = NHibernateHelper.AbreSession();
                var tipoEstabelecimentoDAO = new TipoEstabelecimentoDAO(session);
                tipoEstabelecimentoDAO.Alterar(tipoEstabelecimento);
                session.Close();
                Mensagem = "Dados Alterados com sucesso!";
                Status = true;
            }
            else
            {
                Status = false;
                Mensagem = tipoEstabelecimentoNegocio.Mensagem;
            }
        }
        public List<List<string>> BuscarTipoEstabelecimento()
        {
            ISession session = NHibernateHelper.AbreSession();
            var tipoEstabelecimentoDAO = new TipoEstabelecimentoDAO(session);
            var estabelecimentos = tipoEstabelecimentoDAO.BuscarTipoEstabelecimento();
            session.Close();            
            return estabelecimentos;

        }
        public Tipo_Estabelecimento BuscarTipoEstabelecimentoId(int id)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new TipoEstabelecimentoDAO(session);
            var tipoEstabelecimento = dao.BuscarPorId(id);
            session.Close();
            return tipoEstabelecimento;
        }
        public void ExcluirTipoEstabelecimento(Tipo_Estabelecimento tipoEstabelecimento)
        {
            var negocioTipoEstabelecimento = new TipoEstabelecimentoNegocio();
            if (negocioTipoEstabelecimento.validaExclusao(tipoEstabelecimento))
            {
                Status = true;
                Mensagem = "Dados Excluídos com sucesso.";
                var session = NHibernateHelper.AbreSession();
                var dao = new TipoEstabelecimentoDAO(session);
                dao.Excluir(tipoEstabelecimento);
                session.Close();
            }
            else
            {
                Status = false;
                Mensagem = negocioTipoEstabelecimento.Mensagem;
            }
        }
    }
}
