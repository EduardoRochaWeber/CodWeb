using MvcDBO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcDBO.Context
{
    public class CompContext : DbContext
    {
        public DbSet<Armazenamento> Armazenamento { get; set; }
        public DbSet<Fonte> Fonte { get; set; }
        public DbSet<Gabinete> Gabinete { get; set; }
        public DbSet<MemoriaRam> MemoriaRam { get; set; }
        public DbSet<PlacaDeVideo> PlacaDeVideo { get; set; }
        public DbSet<PlacaMae> PlacaMae { get; set; }
        public DbSet<Processador> Processador { get; set; }
        public CompContext() : base("CompConnection")
        {

        }
    }
}