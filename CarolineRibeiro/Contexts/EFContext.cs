using CarolineRibeiro.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarolineRibeiro.Contexts
{
    public class EFContext : DbContext
    {
            public EFContext() : base("Asp_Net_MVC_CS") { }
            public DbSet<Subject> Subject { get; set; }
            public DbSet<Teacher> Teacher { get; set; }
    }
}