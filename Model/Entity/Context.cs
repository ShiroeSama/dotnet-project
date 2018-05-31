using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    using Entity.Client;
    using Entity.Command;
    using Entity.Product;

    public class Context : DbContext
    {
        public Context() : base("name=ShirOSDB")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Set Schema
            modelBuilder.HasDefaultSchema("dbo");

            // Set Table
            modelBuilder.Configurations
                // Client Dir
                .Add(new ClientFluent())

                // Command Dir
                .Add(new CommandFluent())
                .Add(new CommandProductFluent())
                .Add(new StatusFluent())

                // Product Dir
                .Add(new CategoryFluent())
                .Add(new LogProductFluent())
                .Add(new ProductFluent())
            ;
        }

        // Get & Set Table

        public DbSet<Client.Client> Client { get; set; }
        public DbSet<Command.Command> Command { get; set; }
        public DbSet<Command.CommandProduct> CommandProduct { get; set; }
        public DbSet<Command.Status> Status { get; set; }
        public DbSet<Product.Category> Category { get; set; }
        public DbSet<Product.LogProduct> LogProduct { get; set; }
        public DbSet<Product.Product> Product { get; set; }
    }
}