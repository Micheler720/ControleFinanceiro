
using ControleFinanceiro.Modelo.Modelo;
using ControleFinanceiro.Modelo.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Controle
{
    public class EntradaControle
    {
        public void ValidaEntrada(EntradasModelo entrada)
        {
            var entradaNegocio = new EntradaNegocio();
            entradaNegocio.ValidaEntradaNegocio(entrada);
        }
    }
}
