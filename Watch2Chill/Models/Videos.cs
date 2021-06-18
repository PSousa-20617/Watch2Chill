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
            ListaDeUtilizadores = new HashSet<UtilizadoresVideos>();

        }
        /// <summary>
        /// Id do filme ou série. 
        /// </summary>
        [Key]
        public int IdVideo { get; set; }


        /// <summary>
        /// Nome do filme/série
        /// </summary>
        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        [StringLength(60, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        public string Nome { get; set; }

        
        public string Trailer { get; set; }


        /// <summary>
        /// Género de filme ou de série (EX: Terror, Comédia, Ação, Ficção Científica)
        /// </summary>
        [Required(ErrorMessage = "O Genero é de preenchimento obrigatório")]
        public string Genero { get; set; }


        /// <summary>
        /// Ano de lançamento do Filme ou Série
        /// </summary>
        [Required(ErrorMessage = "O Ano é de preenchimento obrigatório")]
        public int Ano { get; set; }


        /// <summary>
        /// Atores principais que entraram nos filmes ou séries
        /// </summary>
        [Required(ErrorMessage = "O Elenco é de preenchimento obrigatório")]
        public string Elenco { get; set; }



        /// <summary>
        /// Idioma do Filme/Série
        /// </summary>
        [Required(ErrorMessage = "O Idioma é de preenchimento obrigatório")]
        public string Idioma { get; set; }


        /// <summary>
        /// Realizador (ou Criador) do Filme/Série
        /// </summary>
        [Required(ErrorMessage = "O Realizador é de preenchimento obrigatório")]
        public string Realizador { get; set; }


        /// <summary>
        /// Fotografia correspondente ao filme ou série
        /// </summary>
        
        public string Foto { get; set; }

        /// <summary>
        /// Ficheiro mp4 do filme
        /// </summary>
        
        public string Filme { get; set; }


        /// <summary>
        /// Número de temporadas. Se o valor deste atributo for 0, então trata-se de um Filme, caso contrário, trata-se de uma série
        /// </summary>
        public int NTemporadas { get; set; }


        public ICollection<Temporadas> ListaDeTemporadas { get; set; }

        public ICollection<UtilizadoresVideos> ListaDeUtilizadores { get; set; }
    }
}
