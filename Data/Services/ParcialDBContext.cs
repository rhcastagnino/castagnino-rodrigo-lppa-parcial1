using castagnino_rodrigo_lppa_parcial1.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace castagnino_rodrigo_lppa_parcial1.Data.Services
{
    public class ParcialDBContext : DbContext
    {
        public DbSet<Afiliados> Afiliados { get; set; }

        public ParcialDBContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}