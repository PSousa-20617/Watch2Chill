using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watch2Chill.Models;

namespace Watch2Chill.Data
{
    public class Watch2ChillDB :DbContext {

        public Watch2ChillDB(DbContextOptions<Watch2ChillDB> options) : base(options) { }

        public DbSet<Utilizadores> Utilizadores { get; set; }

        public DbSet<Utilizadores_videos> Utilizadores_videos { get; set; }

        public DbSet<Videos> Videos { get; set; }

        public DbSet<Temporadas> Temporadas { get; set; }

        public DbSet<Episodios> Episodios { get; set; }

    }
}
