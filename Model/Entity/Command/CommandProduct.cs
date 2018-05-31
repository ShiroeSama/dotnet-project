using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity.Command
{
    using Entity.Product;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class CommandProduct
    {
        public int Id { get; set; }

        // Foreign Keys
        public int CommandId { get; set; }
        public Command Command { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }

    public class CommandProductFluent : EntityTypeConfiguration<CommandProduct>
    {
        public CommandProductFluent()
        {
            // Name of the table in DB
            ToTable("CommandProduct");

            // Primary Key Attribute
            HasKey(cp => cp.Id);

            // Rules
            Property(cp => cp.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Foreign Keys
            Property(cp => cp.CommandId);
            HasRequired(cp => cp.Command).WithMany().HasForeignKey(cp => cp.CommandId);
            Property(cp => cp.ProductId);
            HasRequired(cp => cp.Product).WithMany().HasForeignKey(cp => cp.ProductId);
        }
    }
}
