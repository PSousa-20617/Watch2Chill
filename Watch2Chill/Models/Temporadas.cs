using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Watch2Chill.Models
{
    public class Temporadas
    {
        public Temporadas(){
            ListaDeEpisodios = new HashSet<Episodios>();

    }
        public int Num { get; set; }

        public int N_episódios { get; set; }

        [ForeignKey("Video")]
        public int Id_VideosFK { get; set; }
        public Videos Id { get; set; }

        public ICollection<Episodios> ListaDeEpisodios { get; set; }
    }
}
