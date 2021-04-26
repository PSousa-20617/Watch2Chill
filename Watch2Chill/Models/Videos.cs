using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Watch2Chill.Models
{
    public class Videos
    {

        public Videos()
        {
            ListaDeTemporadas = new HashSet<Temporadas>();

        }

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Genero { get; set; }

        public DateTime Ano { get; set; }

        public string Elenco { get; set; }

        public string Idioma { get; set; }

        public string Realizador { get; set; }

        public int N_temporadas { get; set; }

        public int N_episodios { get; set; }

        public ICollection<Temporadas> ListaDeTemporadas { get; set; }
    }
}
