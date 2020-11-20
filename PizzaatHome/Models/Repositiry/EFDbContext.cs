using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace PizzaatHome.Models.Repositiry
{
    public class EFDbContext : DbContext
    {
        public DbSet<Pizza> Pizza { get; set; } 
    }
}