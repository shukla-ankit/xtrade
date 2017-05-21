using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xtrade.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<xtrade.Models.Item> Items { get; set; }

        public System.Data.Entity.DbSet<xtrade.Models.Image> Images { get; set; }

        public System.Data.Entity.DbSet<xtrade.Models.BargainRecord> BargainRecords { get; set; }

        public System.Data.Entity.DbSet<xtrade.Models.Category> Categories { get; set; }
    }
}