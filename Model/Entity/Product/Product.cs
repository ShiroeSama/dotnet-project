using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity.Product
{
    public class Product
    {
        public int Id { get; set; }
        public String Code { get; set; }
        public String Label { get; set; }
        public String Description { get; set; }
        public Boolean Actif { get; set; }
        public int Stock { get; set; }
        public float Prix { get; set; }

        // Foreign Keys
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product()
        {
            this.Actif = false;
        }
    }

    public class ProductFluent : EntityTypeConfiguration<Product>
    {
        public ProductFluent()
        {
            // Name of the table in DB
            ToTable("Product");

            // Primary Key Attribute
            HasKey(p => p.Id);

            // Rules
            Property(p => p.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Code).IsRequired().HasMaxLength(50);
            Property(p => p.Label).IsRequired().HasMaxLength(50);
            Property(p => p.Description).IsRequired().HasMaxLength(50);
            Property(p => p.Actif).IsRequired();
            Property(p => p.Stock).IsRequired();
            Property(p => p.Prix).IsRequired();

            // Foreign Keys
            Property(p => p.CategoryId);
            HasRequired(p => p.Category).WithMany().HasForeignKey(p => p.CategoryId);
        }
    }
}
