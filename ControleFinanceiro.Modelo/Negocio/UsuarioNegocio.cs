using ControleFinanceiro.Modelo.Controle;
using ControleFinanceiro.Modelo.DAO;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Negocio
{
    internal class UsuarioNegocio
    {
        internal bool ValidarEmail(Usuario usuario)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new UsuarioDAO(session);
            var retorno = dao.BuscarPorEmail(usuario.Email);
            session.Close();
            return retorno is null;
        }
    }
}
