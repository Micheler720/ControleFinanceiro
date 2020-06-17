using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.DAO;
using ControleFinanceiro.Modelo.DAO.ConexaoMysql;
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
    internal class TipoEstabelecimentoNegocio
    {
        public string Mensagem = "";
        public bool validaTipoEstabelecimentoNegocio(Tipo_Estabelecimento estabelecimento)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new TipoEstabelecimentoDAO(session);
            var tipoEstabelecimento = dao.BuscarTipoEstabelecimento(descricao: estabelecimento.Descricao);
            session.Close();
            if(tipoEstabelecimento != null)
            {
                Mensagem = "Não é possível gravar tipos de estabelecimento com o mesmo nome";
                return false;
            }
            return true;
        }
        public bool validaAlteracao(Tipo_Estabelecimento estabelecimento)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new TipoEstabelecimentoDAO(session);
            var tipoEstabelecimento = dao.BuscarTipoEstabelecimentoDescricao(id:estabelecimento.Id ,descricao: estabelecimento.Descricao);
            session.Close();
            if (tipoEstabelecimento != null)
            {
                Mensagem = "Não é possível gravar tipos de estabelecimento com o mesmo nome";
                return false;
            }
            return true;
        }
        public bool validaExclusao(Tipo_Estabelecimento tipoEstabelecimento)
        {
            var session = NHibernateHelper.AbreSession();
            var daoEstabeLecimento = new EstabelecimentoDAO(session);
            var estabelecimento = daoEstabeLecimento.BuscarEstabelecimento(tipoEstabelecimento:tipoEstabelecimento);
            session.Close();
            if (estabelecimento != null)
            {
                Mensagem = "Existem estabelecimentos vinculados ao Tipo Esbelecimento. Verifiqe para exclusão.";
                return false;
            }
            return true;
        }
    }
}
