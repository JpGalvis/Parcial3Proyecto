using Microsoft.EntityFrameworkCore;
using Parcial3Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial3Proyecto.Data
{
    public class AppDbContext : DbContext

    {


        public DbSet<Usuario> Usuarios { get; set; } //Llama al modelo (Person) 


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {



        }

    }
}