using ControleFinanceiro.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Negocio
{
    internal class AutenticarNegocio
    {
        internal static bool ValidaSenha(UsuarioModelo usuario)
        {
            if(usuario.Senha == "teste" && usuario.Usuario == "Michele")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
