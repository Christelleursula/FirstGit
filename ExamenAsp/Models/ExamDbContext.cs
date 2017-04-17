using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamenAsp.Models
{
    public class ExamDbContext : DbContext
    {
        public ExamDbContext(): base("DefaultConnection")
        {

        }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<Client> Client { get; set; }

    }

    
}