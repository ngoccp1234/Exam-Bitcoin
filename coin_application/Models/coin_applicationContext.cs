using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace coin_application.Models
{
    public class coin_applicationContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public coin_applicationContext() : base("name=coin_applicationContext")
        {
        }

        public System.Data.Entity.DbSet<coin_application.Models.Coin> Coins { get; set; }

        public System.Data.Entity.DbSet<coin_application.Models.Market> Markets { get; set; }
    }
}
