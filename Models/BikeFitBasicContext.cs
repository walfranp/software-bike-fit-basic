using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFitBasic.Models
{
    internal class BikeFitBasicContext : DbContext
    {
        //Tabelas do banco aqui
        public DbSet<Ciclista> Ciclistas { get; set; }

        //Sobreescrever o metodo Onconfiguring para acessar o banco de dados SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=fit.db");
        }
    }
}
