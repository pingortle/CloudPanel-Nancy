using CloudPanel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CloudPanel.Persistence
{
    internal sealed class CloudPanelDbConfiguration : DbConfiguration
    {
        public CloudPanelDbConfiguration() : base()
        {
            SetDefaultConnectionFactory(new SqlConnectionFactory());
        }
    }

    internal sealed class CloudPanelContextInitializer : DropCreateDatabaseAlways<CloudPanelContext>
    {
        protected override void Seed(CloudPanelContext context)
        {
            var noClaim = new Claim { Key = "None" };
            var adminClaim = new Claim { Key = "Admin" };

            context.Users.AddRange(new[] {
                new User
                {
                    Username = "charlie@regularjoe.com",
                    Password = "SomeDumbPassword",
                    Guid = Guid.NewGuid(),
                    Claims = new[] { noClaim, },
                },
                new User
                {
                    Username = "admin@important.stuff",
                    Password = "SuperSecure",
                    Guid = Guid.NewGuid(),
                    Claims = new[] { adminClaim, },
                },
            });

            context.SaveChanges();
        }
    }

    public sealed class CloudPanelContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>()
                .Configure(x => x.IsRequired());

            base.OnModelCreating(modelBuilder);
        }

        static CloudPanelContext()
        {
            Database.SetInitializer(new CloudPanelContextInitializer());
        }
    }
}
