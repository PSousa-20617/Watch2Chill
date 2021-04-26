using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Watch2Chill.Models
{
    public class Utilizadores_videos
    {
        /// <summary>
        /// Atributo que identifica o atributo Id da classe Utilizadores.
        /// </summary>
        [Key]
        public int Id_Utilizadores { get; set; }
        public Utilizadores Id { get; set; }

        /// <summary>
        /// Atributo que identifica o atributo Id da classe Videos.
        /// </summary>
        [Key]
        public int Id_Videos { get; set; }
        public Videos Video { get; set; }
    }
}
