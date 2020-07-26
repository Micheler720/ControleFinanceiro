using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo
{
    public class UsuarioModelo
    {
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Nome { get; set; }
        public int Id { get; set; }
        public int Sexo { get; private set; }
        public string CamminhoFoto { get; private set; }
        public UsuarioModelo (string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
        public override string ToString()
        {
            return Email;
        }
    }
}
