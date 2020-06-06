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
        public void controleCadastroEstabelecimento(Estabelecimento estabelecimento)
        {

            var EstabelecimentoNegocio = new EstabelecimentoNegocio();
            if (EstabelecimentoNegocio.ValidaCadastroEstabelecimento(estabelecimento))
            {
                NHibernateHelper.GeraSchema();
                var session = NHibernateHelper.AbreSession();
                var estabelecimentoDAO = new EstabelecimentoDAO(session);
                estabelecimentoDAO.Adiciona(estabelecimento);
                session.Close();
            } 
        }
    }
}
