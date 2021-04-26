using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Watch2Chill.Models
{
    public class Temporadas
    {

        /// <summary>
        /// Lista de episódios de uma determinada temporada
        /// </summary>
        public Temporadas(){
            ListaDeEpisodios = new HashSet<Episodios>();

    }

        /// <summary>
        /// Atributo que identifica a temporada pelo seu número
        /// </summary>
        [Key]
        public int Num { get; set; }

        /// <summary>
        /// Número de episódios de uma respetiva temporada
        /// </summary>
        public int N_episódios { get; set; }


        /// <summary>
        /// Atributo chave forasteira que relaciona a temporada com a sua respetiva série
        /// </summary>
        [ForeignKey("Video")]
        public int Id_VideosFK { get; set; }
        public Videos Id { get; set; }


        /// <summary>
        /// Coleção lista de episodios de uma dada temporada
        /// </summary>
        public ICollection<Episodios> ListaDeEpisodios { get; set; }
    }
}
