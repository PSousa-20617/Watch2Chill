using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Watch2Chill.Models
{
    public class UtilizadoresVideos
    {
        /// <summary>
        /// Atributo que identifica o atributo Id da classe Utilizadores.
        /// </summary>
        [Column(Order = 1)]
        public int Id_Utilizadores { get; set; }
        public Utilizadores Id { get; set; }

        /// <summary>
        /// Atributo que identifica o atributo Id da classe Videos.
        /// </summary>
        [Column(Order = 2)]
        public int IdVideos { get; set; }
        public Videos Video { get; set; }

        [ForeignKey("Utilizador")]
        public int IdUtilizadorFK { get; set; }
        public Utilizadores IdUtilizador { get; set; }

        [ForeignKey("Videos")]
        public int IdVideoFK { get; set; }
        public Videos IdVideo { get; set; }
    }
}
