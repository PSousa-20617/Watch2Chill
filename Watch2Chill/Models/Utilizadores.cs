using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watch2Chill.Models
{
    public class Utilizadores
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Morada { get; set; }

        public string Sexo { get; set; }

        public DateTime Data_nascimento{ get; set; }

        public string Tipo { get; set; }
    }
}
