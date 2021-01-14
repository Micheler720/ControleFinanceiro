using ControleFinanceiro.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Modelo
{
    public class FinEntradasModelo : Fin_Receber
    {
        public class Unit
        {
            public  int Id { get; private set; }
            public  string Documento { get; set; }
            public  string DataLancamento { get; set; }
            public  int CodEstabelecimento { get; set; }
            public  double Valor { get; private set; }
            public  string Observacao { get; set; }
            public Unit (double valor)
            {
                Valor = valor;
            }


        }
        public class List
        {
            public List<Unit> ListEntradas { get; set; }
        }
    }
}
