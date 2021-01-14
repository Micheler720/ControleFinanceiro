using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Integracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Controle
{
    public class IntegracaoControle
    {
        public string Mensagem;
        public bool Integrar(Integracao dados)
        {
            var Integracao = new IntegracaoNubank();
            Integracao.Integrar(dados);
            Mensagem = Integracao.Mensagem;
            return true;
        }
    }
}
