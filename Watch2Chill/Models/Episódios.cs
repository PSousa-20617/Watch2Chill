using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Watch2Chill.Models
{
    public class Episodios
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [ForeignKey("Temporada")]
        public int Num_temporadaFK { get; set; }
        public Temporadas Num { get; set; }
    }
}
