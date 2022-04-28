using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace testingproject.Models
{
    public class Context:DbContext
    {
        public Context()
                 : base("name=Manudb")
        {
        }

       public DbSet<OrderDetails> orderDetails { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}