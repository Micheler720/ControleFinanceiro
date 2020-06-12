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
        bool Status;
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
            }
        }
        public void AlterarTipoEstabelecimento(Tipo_Estabelecimento tipoEstabelecimento)
        {
            var tipoEstabelecimentoNegocio = new TipoEstabelecimentoNegocio();
            if (tipoEstabelecimentoNegocio.validaTipoEstabelecimentoNegocio(tipoEstabelecimento))
            {
                ISession session = NHibernateHelper.AbreSession();
                var tipoEstabelecimentoDAO = new TipoEstabelecimentoDAO(session);
                tipoEstabelecimentoDAO.Alterar(tipoEstabelecimento);
                session.Close();
                Mensagem = "Dados Alterados com sucesso!";
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
            return tipoEstabelecimento;
        }
        public void ExcluirTipoEstabelecimento(Tipo_Estabelecimento estabelecimento)
        {
            Status = true;
            Mensagem = "Dados Excluídos com sucesso.";
            var session = NHibernateHelper.AbreSession();
            var dao = new TipoEstabelecimentoDAO(session);
            dao.Excluir(estabelecimento);
        }
    }
}
