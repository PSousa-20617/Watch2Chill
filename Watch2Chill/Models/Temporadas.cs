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
        /// Atributo que relaciona o id da temporada com a respetiva série
        /// </summary>
        [Key]
        public int IdSerie { get; set; }


        /// <summary>
        /// Atributo que menciona o número de temporadas de uma dada série, dado o seu Id
        /// </summary>
        public int NumTemps { get; set; }


        public int NumEps { get; set; }


        public string DataFim { get; set; }


        /// <summary>
        /// Atributo chave forasteira que relaciona a temporada com a sua respetiva série
        /// </summary>
        [ForeignKey("Video")]
        public int IdVideosFK { get; set; }
        public Videos Id { get; set; }

       
        /// <summary>
        /// Coleção lista de episodios de uma dada temporada
        /// </summary>
        public ICollection<Episodios> ListaDeEpisodios { get; set; }
    }
}
