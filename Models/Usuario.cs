using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verify.Models
{
    public class Usuario
    {

        public int IdUsuario { get; set; }
        public string NomeCompleto{ get; set; }
        public string NomeUsuario{ get; set; }
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public DateTime DataNascUsuario { get; set; }
        public string TipoPlano { get; set; }

    }

    public class UsuarioCollection : List<Usuario> { }

}
