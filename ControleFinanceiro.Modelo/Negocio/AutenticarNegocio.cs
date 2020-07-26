using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.DAO;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Helpers;
using ControleFinanceiro.Modelo.Util;
using ControleFinanceiro.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Negocio
{
    internal class AutenticarNegocio
    {
        private Hash crip = new Hash(SHA512.Create());
        internal string Mensagem;
        internal bool ValidarSenha(string email, string senha)
        {
            var session = NHibernateHelper.AbreSession();
            var dao = new UsuarioDAO(session);
            var usuario = dao.BuscarPorEmail(email);
            session.Close();
            if(crip.VerificarSenha(senha, usuario.Senha))
            {
                return true;
            }
            else
            {
                Mensagem = "Usuário ou senha incorretos, verifique.";
                return false;
            }
        }
    }
}
