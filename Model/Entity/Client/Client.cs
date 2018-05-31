using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity.Client
{
    public class Client
    {
        public int Id { get; set; }
        public String Lastname { get; set; }
        public String Firstname { get; set; }
        public Boolean Actif { get; set; }

        public Client()
        {
            this.Actif = false;
        }
    }

    public class ClientFluent : EntityTypeConfiguration<Client>
    {
        public ClientFluent()
        {
            // Name of the table in DB
            ToTable("Client");

            // Primary Key Attribute
            HasKey(c => c.Id);

            // Rules
            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Lastname).IsRequired().HasMaxLength(50);
            Property(c => c.Firstname).IsRequired().HasMaxLength(50);
            Property(c => c.Actif).IsRequired();
        }
    }
}
