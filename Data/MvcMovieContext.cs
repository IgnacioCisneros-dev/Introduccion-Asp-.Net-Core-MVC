using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Introduccion_Net_Core.Models;
using Microsoft.EntityFrameworkCore;


namespace Introduccion_Net_Core.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Pelicula> Movie { get; set; }
    }
}
