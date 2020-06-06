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
        public void validaTipoEstabelecimento(Tipo_Estabelecimento tipoEstabelecimento)
        {
            var tipoEstabelecimentoNegocio = new TipoEstabelecimentoNegocio();   
            if (tipoEstabelecimentoNegocio.validaTipoEstabelecimentoNegocio(tipoEstabelecimento))
            {
                NHibernateHelper.GeraSchema();
                ISession session = NHibernateHelper.AbreSession();                
                var tipoEstabelecimentoDAO = new TipoEstabelecimentoDAO(session);
                tipoEstabelecimentoDAO.Adiciona(tipoEstabelecimento);
                session.Close();
            }
        }
    }
}
