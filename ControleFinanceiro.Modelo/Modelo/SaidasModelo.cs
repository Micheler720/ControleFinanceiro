using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Modelo
{
    public class SaidasModelo
    {
        public int Codigo { get; private set; }
        public string Documento { get; set; }
        public string DataLancamento { get; set; }
        public int CodEstabelecimento { get; set; }
        public double Valor { get; private set; }
        public string Observacao { get; set; }
        public SaidasModelo(int codigo, double valor)
        {
            Codigo = codigo;
            Valor = valor;
        }
    }
}
