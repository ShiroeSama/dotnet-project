using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity.Product
{
    public class LogProduct
    {
        public int Id { get; set; }
        public String Message { get; set; }
        public DateTime Date { get; set; }

        // Foreign Keys
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public LogProduct()
        {
            this.Date = DateTime.Now;
        }
    }

    public class LogProductFluent : EntityTypeConfiguration<LogProduct>
    {
        public LogProductFluent()
        {
            // Name of the table in DB
            ToTable("LogProduct");

            // Primary Key Attribute
            HasKey(lp => lp.Id);

            // Rules
            Property(lp => lp.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(lp => lp.Message).IsRequired().HasMaxLength(50);
            Property(lp => lp.Date).IsRequired();

            // Foreign Keys
            Property(lp => lp.ProductId);
            HasRequired(lp => lp.Product).WithMany().HasForeignKey(lp => lp.ProductId);
        }
    }
}
