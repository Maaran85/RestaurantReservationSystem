using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Restaurant_Reservation_System.Data
{
    public class Restaurant_Reservation_SystemContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Restaurant_Reservation_SystemContext() : base("name=Restaurant_Reservation_SystemContext")
        {
        }

        public System.Data.Entity.DbSet<Framework.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<Framework.Table> Tables { get; set; }

        public System.Data.Entity.DbSet<Framework.Restaurant> Restaurants { get; set; }

        public System.Data.Entity.DbSet<Framework.Reservation> Reservations { get; set; }
    }
}
