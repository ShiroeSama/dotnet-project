using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity.Command
{
    public class Status
    {
        public int Id { get; set; }
        public String Label { get; set; }
    }

    public class StatusFluent : EntityTypeConfiguration<Status>
    {
        public StatusFluent()
        {
            // Name of the table in DB
            ToTable("Status");

            // Primary Key Attribute
            HasKey(s => s.Id);

            // Rules
            Property(s => s.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Label).IsRequired().HasMaxLength(50);
        }
    }
}
