using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace coin_application.Models
{
    public class MyDbContext : IdentityDbContext<User>
    {
        public MyDbContext() : base("name=MyDbContext")
        {

        }
        public DbSet<Coin> Coins { get; set; }
        public DbSet<Market> Markets { get; set; }


        public static MyDbContext Create()
        {
            return new MyDbContext();
        }
    }
}