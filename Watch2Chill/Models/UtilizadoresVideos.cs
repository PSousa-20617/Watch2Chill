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
        [Key]
        public int Id { get; set; }

        //Chave Forasteira que representa o Id do Utilizador
        [ForeignKey(nameof(IdUtilizador))]
        public int IdUtilizadorFK { get; set; }
        public Utilizadores IdUtilizador { get; set; }

        //Chave Forasteira que representa o Id do Vídeo
        [ForeignKey(nameof(IdVideo))]
        public int IdVideoFK { get; set; }
        public Videos IdVideo { get; set; }
    }
}
