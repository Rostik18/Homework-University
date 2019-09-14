using Microsoft.EntityFrameworkCore;

namespace BankApplication {

    class BankDbContext : DbContext {

        public BankDbContext() {

            Database.EnsureCreated();
        }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder ) {

            optionsBuilder.UseSqlServer( "Server=(localdb)\\mssqllocaldb;Database=BankDB;Trusted_Connection=True;" );
        }
    }
}
