using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watch2Chill.Models
{
    public class Utilizadores_videos
    {
        
        public int Id_Utilizadores { get; set; }
        public Utilizadores Id { get; set; }

        public int Id_Videos { get; set; }
        public Videos Video { get; set; }
    }
}
