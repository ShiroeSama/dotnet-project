using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity.Product
{
    public class Category
    {
        public int Id { get; set; }
        public String Label { get; set; }
        public Boolean Actif { get; set; }

        public Category()
        {
            this.Actif = false;
        }
    }

    public class CategoryFluent : EntityTypeConfiguration<Category>
    {
        public CategoryFluent()
        {
            // Name of the table in DB
            ToTable("Category");

            // Primary Key Attribute
            HasKey(c => c.Id);

            // Rules
            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Label).IsRequired().HasMaxLength(50);
            Property(c => c.Actif).IsRequired();
        }
    }
}
