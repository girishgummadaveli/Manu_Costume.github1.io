using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace testingproject.Models
{
    public class OrderDetails:DbSet
    {
        [Key]
        public int Id { get; set; }
        public string ORDERID { get; set; }
        public string ORDERNAME { get; set; }
        public string NAME { get; set; }
        public string EMAILID { get; set; }
        public string MOBILENUMBER { get; set; }
        public string LOCATION { get; set; }
        public string Updated_User { get; set; }
        public DateTime Updated_Date { get; set; }
    }

    public class Login : DbSet
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        
    }
}