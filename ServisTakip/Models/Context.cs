using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServisTakip.Models
{
    public class Context:DbContext
    {
        public DbSet<Kisi> Kisis { get; set; }
        public DbSet<Servis> Servis { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
    }
}