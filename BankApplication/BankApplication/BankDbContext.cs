using BankApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankApplication {

    class BankDbContext : DbContext {

        public BankDbContext() {

            Database.EnsureCreated();
        }

        DbSet<UserEntity> Users { get; set; }
        DbSet<BankAccountEntity> BankAccounts { get; set; }
        DbSet<CreditCardEntity> CreditCards { get; set; }

        DbSet<CreditTypeEntity> CreditTypes { get; set; }
        DbSet<DepositTypeEntity> DepositTypes { get; set; }

        DbSet<UserCreditEntity> UserCredits { get; set; }
        DbSet<UserDepositEntity> UserDeposits { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder ) {

            optionsBuilder.UseSqlServer( "Server=(localdb)\\mssqllocaldb;Database=BankDB;Trusted_Connection=True;" );
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder ) {

            modelBuilder.Entity<UserEntity>()
                    .ToTable( "Users" ).HasKey( p => p.Id );

            modelBuilder.Entity<BankAccountEntity>()
                    .ToTable( "BankAccounts" ).HasKey( p => p.Id );

            modelBuilder.Entity<CreditCardEntity>()
                .ToTable( "CreditCards" ).HasKey( p => p.Id );

            //Deposit - Credit types settings.
            modelBuilder.Entity<CreditTypeEntity>()
                .ToTable( "CreditTypes" ).HasKey( p => p.Id );

            modelBuilder.Entity<DepositTypeEntity>()
               .ToTable( "DepositTypes" ).HasKey( p => p.Id );

            //User Deposits - Credits settings.
            modelBuilder.Entity<UserCreditEntity>()
               .ToTable( "UserCredits" ).HasKey( p => p.Id );

            modelBuilder.Entity<UserDepositEntity>()
               .ToTable( "UserDeposits" ).HasKey( p => p.Id );
        }
    }
}
