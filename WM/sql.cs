using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WM.Models;

namespace WM
{
    public class sql :DbContext
    {
        public sql() : base("con") { }

        public DbSet<Kategorija> Kategorija { get; set; }
        public DbSet<Dobavljac> Dobavljac { get; set; }
        public DbSet<Proizvodac> Proizvodac { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
    }
}