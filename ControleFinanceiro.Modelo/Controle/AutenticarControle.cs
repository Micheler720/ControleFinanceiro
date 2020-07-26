using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.DAO;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Excexoes;
using ControleFinanceiro.Modelo.Helpers;
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
        public string Mensagem;
        public bool ControleSenhaValida(string email, string senha)
        {
            var negocio = new AutenticarNegocio();
            if (negocio.ValidarSenha(email, senha))
            {
                return true;
            }
            else
            {
                Mensagem = negocio.Mensagem;
                return false;
            }
            
        }
    }
}
