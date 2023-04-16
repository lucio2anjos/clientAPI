using Client_Management.Class;
using Microsoft.EntityFrameworkCore;

namespace Client_Management.Model.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ClientDB");
        }
    }
}
