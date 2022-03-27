using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaListaDeContatos.Models
{
    public class Contato
    {
        public int IdContato { get; set; }
        public string Nome { get; set; }
        public string Telefone{ get; set; }
        public string Email { get; set; }
        public Endereco Endereco{ get; set; }


        public Contato()
        {
            Endereco = new Endereco();
        }

    }
}
