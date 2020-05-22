using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.Excexoes;
using ControleFinanceiro.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Controle
{
    public class AutenticarControle
    {
        public void ControleSenhaValida(UsuarioModelo usuario)
        {
            var autenticar =  AutenticarNegocio.ValidaSenha(usuario);
            if (!autenticar)
            {
                throw new AutenticarException("Usuário ou senha Incorretos. Verifique");
            }

        }
    }
}
