using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Negocio
{
    internal class ValoresFixosNegocio
    {
        public string Mensagem = "";

        internal bool ValidaDespesaFixa(Valores_Fixos DespesaFixa)
        {
            return true;
        }
        
    }
}
