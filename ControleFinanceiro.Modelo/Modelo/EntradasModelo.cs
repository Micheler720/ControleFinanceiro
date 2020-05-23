using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Modelo
{
    public class EntradasModelo
    {
        public int Codigo { get; private set; }
        public int CodEstabelecimento { get; set; }
        public double Valor { get; private set; }
        public string Observacao { get; set; }
        public EntradasModelo(int codigo, double valor)
        {
            Codigo = codigo;
            Valor = valor;
        }
    }
}
