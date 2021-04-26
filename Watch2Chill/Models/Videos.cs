using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Watch2Chill.Models
{
    public class Videos
    {
        /// <summary>
        /// Lista de temporadas 
        /// </summary>
        public Videos()
        {
            ListaDeTemporadas = new HashSet<Temporadas>();

        }
        /// <summary>
        /// Id do filme ou série. 
        /// </summary>
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Nome do filme/série
        /// </summary>
        public string Nome { get; set; }


        /// <summary>
        /// Género de filme ou de série (EX: Terror, Comédia, Ação, Ficção Científica)
        /// </summary>
        public string Genero { get; set; }


        /// <summary>
        /// Ano de lançamento do Filme ou Série
        /// </summary>
        public DateTime Ano { get; set; }


        /// <summary>
        /// Atores principais que entraram nos filmes ou séries
        /// </summary>
        public string Elenco { get; set; }



        /// <summary>
        /// Idioma do Filme/Série
        /// </summary>
        public string Idioma { get; set; }


        /// <summary>
        /// Realizador (ou Criador) do Filme/Série
        /// </summary>
        public string Realizador { get; set; }


        /// <summary>
        /// Número de temporadas. Se o valor deste atributo for 0, então trata-se de um Filme, caso contrário, trata-se de uma série
        /// </summary>
        public int N_temporadas { get; set; }


        /// <summary>
        /// Numero de episódios de uma série, numa determinada temporada
        /// </summary>
        public int N_episodios { get; set; }

        public ICollection<Temporadas> ListaDeTemporadas { get; set; }
    }
}
