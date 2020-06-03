using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo
{
    public class UsuarioModelo
    {
        public string Usuario { get; private set; }
        public string Senha { get; private set; }
        public int Id { get; private set; }

        public UsuarioModelo (string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}
