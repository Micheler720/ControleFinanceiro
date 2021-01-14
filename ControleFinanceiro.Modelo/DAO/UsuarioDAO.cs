using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Util;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.DAO
{
    public class UsuarioDAO
    {
        private ISession session;

        internal UsuarioDAO(ISession session)
        {
            this.session = session;
        }
        internal void Adiciona(Usuario usuario)
        {
            var transacao = session.BeginTransaction();
            session.Save(usuario);
            transacao.Commit();

        }
        internal void Alterar(Usuario usuario)
        {
            var transacao = session.BeginTransaction();
            session.Update(usuario);
            transacao.Commit();

        }
        internal Usuario BuscarPorId(int id)
        {
            
            return session.Get<Usuario>(id);

        }
        internal Usuario BuscarPorEmail(string email)
        {
            using (var transacao = session.BeginTransaction())
            {
                var crit = session.CreateCriteria("Usuario");
                crit.Add(NHibernate.Criterion.Restrictions.Eq("Email", email));
                Usuario usuario = crit.SetMaxResults(1).UniqueResult<Usuario>();
                transacao.Commit();
                return usuario;
            }

        }
        internal List<Usuario> BuscarUsuarios()
        {
            using (var transacao = session.BeginTransaction())
            {
                var hql = "from Usuario";
                var query = session.CreateQuery(hql);
                transacao.Commit();
                List<Usuario> usuarios = (List<Usuario>)query.List<Usuario>();
                return usuarios;
            }
        }
    }
}
