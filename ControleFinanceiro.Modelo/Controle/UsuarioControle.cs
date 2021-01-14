using ControleFinanceiro.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Modelo.Negocio;
using ControleFinanceiro.Modelo.Helpers;
using ControleFinanceiro.Modelo.DAO;

namespace ControleFinanceiro.Modelo.Controle
{
    public class UsuarioControle
    {
        public string Mensagem { get; set; }
        public bool alterarUsuario(Usuario usuario)
        {
            var negocio = new UsuarioNegocio();
            var session = NHibernateHelper.AbreSession();
            var dao = new UsuarioDAO(session);
            dao.Alterar(usuario);
            session.Close();
            Mensagem = "Usuario alterado com sucesso!";
            return true;
        }
        public bool gravarUsuario(Usuario usuario)
        {
            var negocio = new UsuarioNegocio();
            if (negocio.ValidarEmail(usuario))
            {
                var session = NHibernateHelper.AbreSession();
                var dao = new UsuarioDAO(session);
                dao.Adiciona(usuario);
                session.Close();
                Mensagem = "Usuario Salvo com sucesso!";
                return true;
            }
            Mensagem = "E-mail já cadastro, verifique.";
            return false;
        }
        public Usuario buscarUsuarioId(int id)
        {
            var usuario = new Usuario();
            var session = NHibernateHelper.AbreSession();
            var dao = new UsuarioDAO(session);
            usuario = dao.BuscarPorId(id);
            session.Close();
            return usuario;
        }
        public List<Usuario> BuscarUsuario()
        {
            var usuario = new List<Usuario>();
            var session = NHibernateHelper.AbreSession();
            var dao = new UsuarioDAO(session);
            usuario = dao.BuscarUsuarios();
            session.Close();
            return usuario;
        }
    }
}
