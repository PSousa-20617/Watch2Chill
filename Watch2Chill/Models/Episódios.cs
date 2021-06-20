using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Watch2Chill.Models
{
    public class Episodios
    {

        /// <summary>
        /// Atributo Id identifica o episódio (ep.1, ep.2, etc..)
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Atributo que identifica o nome do respetivo episódio
        /// </summary>
        public string Nome { get; set; }

        public string Foto { get; set; }

        public string Video { get; set; }


        /// <summary>
        /// Atributo Chave forasteira, que identifica o Id da temporada na classe Temporadas, para que seja possível relacionar um dado episódio com a sua Temporada correta
        /// </summary>
        [ForeignKey("Temporada")]
        [Display(Name = "Temporada")]
        public int Id_serieFK { get; set; }
        public Temporadas Id_serie { get; set; }
    }
}
