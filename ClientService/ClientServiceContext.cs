namespace ClientService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClientServiceContext : DbContext
    {
        public DbSet<ClientData> Clients { get; set; }
        public ClientServiceContext()
            : base("name=ClientServiceContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
