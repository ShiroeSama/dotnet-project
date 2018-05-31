using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity.Command
{
    using Entity.Client;

    public class Command
    {
        public int Id { get; set; }
        public DateTime DateCommand { get; set; }
        public string Observation { get; set; }

        // Foreign Keys
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public Command()
        {
            this.DateCommand = DateTime.Now;
        }
    }

    public class CommandFluent : EntityTypeConfiguration<Command>
    {
        public CommandFluent()
        {
            // Name of the table in DB
            ToTable("Command");

            // Primary Key Attribute
            HasKey(c => c.Id);

            // Rules
            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Observation).IsRequired().HasMaxLength(50);
            Property(c => c.DateCommand).IsRequired();

            // Foreign Keys
            Property(c => c.StatusId);
            HasRequired(c => c.Status).WithMany().HasForeignKey(c => c.StatusId);
            Property(c => c.ClientId);
            HasRequired(c => c.Client).WithMany().HasForeignKey(c => c.ClientId);
        }
    }
}
