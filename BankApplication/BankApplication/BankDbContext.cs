using BankApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankApplication {

    class BankDbContext : DbContext {

        public BankDbContext() {

            // Database.EnsureCreated();
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<BankAccountEntity> BankAccounts { get; set; }
        public DbSet<CreditCardEntity> CreditCards { get; set; }

        public DbSet<CreditTypeEntity> CreditTypes { get; set; }
        public DbSet<DepositTypeEntity> DepositTypes { get; set; }

        public DbSet<UserCreditEntity> UserCredits { get; set; }
        public DbSet<UserDepositEntity> UserDeposits { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder ) {

            optionsBuilder.UseSqlServer( "Server=(localdb)\\mssqllocaldb;Database=BankDB;Trusted_Connection=True;" );
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder ) {

            modelBuilder.Entity<UserEntity>().ToTable( "Users" ).HasKey( p => p.Id );
            modelBuilder.Entity<UserEntity>().Property( p => p.FirstName ).HasMaxLength( 30 ).IsRequired();
            modelBuilder.Entity<UserEntity>().Property( p => p.LastName ).HasMaxLength( 30 ).IsRequired();
            modelBuilder.Entity<UserEntity>().Property( p => p.BirthdayDate ).IsRequired();
            modelBuilder.Entity<UserEntity>().Property( p => p.RegistrationDate ).HasDefaultValueSql( "getutcdate()" );
            modelBuilder.Entity<UserEntity>().Property( p => p.EmailAdress ).HasMaxLength( 30 ).IsRequired();
            modelBuilder.Entity<UserEntity>().Property( p => p.PhoneNumber ).HasMaxLength( 13 ).IsRequired();
            modelBuilder.Entity<UserEntity>().Property( p => p.Password ).HasMaxLength( 30 ).IsRequired();

            modelBuilder.Entity<BankAccountEntity>().ToTable( "BankAccounts" ).HasKey( p => p.Id );
            modelBuilder.Entity<BankAccountEntity>().Property( p => p.Currency ).IsRequired();
            modelBuilder.Entity<BankAccountEntity>().Property( p => p.MoneyCount ).IsRequired();
            modelBuilder.Entity<BankAccountEntity>().Property( p => p.IsFrozen ).IsRequired();
            modelBuilder.Entity<BankAccountEntity>().HasOne( ba => ba.User ).WithMany( u => u.BankAccounts )
                                                    .HasForeignKey( ba => ba.UserId ).OnDelete( DeleteBehavior.Cascade );

            modelBuilder.Entity<CreditCardEntity>().ToTable( "CreditCards" ).HasKey( p => p.Id );
            modelBuilder.Entity<CreditCardEntity>().Property( p => p.CardType ).IsRequired();
            modelBuilder.Entity<CreditCardEntity>().Property( p => p.ExpirationDate ).IsRequired();
            modelBuilder.Entity<CreditCardEntity>().Property( p => p.PIN ).HasMaxLength( 4 ).IsRequired();
            modelBuilder.Entity<CreditCardEntity>().HasOne( cc => cc.BankAccount ).WithMany( ba => ba.CreditCards )
                                                   .HasForeignKey( cc => cc.BankAccountId ).OnDelete( DeleteBehavior.Cascade );

            //Deposit - Credit types settings.
            modelBuilder.Entity<CreditTypeEntity>().ToTable( "CreditTypes" ).HasKey( p => p.Id );
            modelBuilder.Entity<CreditTypeEntity>().Property( p => p.CreditTitle ).HasMaxLength( 30 ).IsRequired();
            modelBuilder.Entity<CreditTypeEntity>().Property( p => p.InterestRate ).IsRequired();
            modelBuilder.Entity<CreditTypeEntity>().Property( p => p.PayoutPeriod ).IsRequired();
            modelBuilder.Entity<CreditTypeEntity>().Property( p => p.PercentType ).IsRequired();
            modelBuilder.Entity<CreditTypeEntity>().HasMany( ct => ct.UserCredits ).WithOne( uc => uc.CreditType )
                                                   .HasForeignKey( uc => uc.CreditTypeId ).OnDelete( DeleteBehavior.Cascade );

            modelBuilder.Entity<DepositTypeEntity>().ToTable( "DepositTypes" ).HasKey( p => p.Id );
            modelBuilder.Entity<DepositTypeEntity>().Property( p => p.DepositTitle ).HasMaxLength( 30 ).IsRequired();
            modelBuilder.Entity<DepositTypeEntity>().Property( p => p.InterestRate ).IsRequired();
            modelBuilder.Entity<DepositTypeEntity>().Property( p => p.PayoutPeriod ).IsRequired();
            modelBuilder.Entity<DepositTypeEntity>().Property( p => p.PercentType ).IsRequired();
            modelBuilder.Entity<DepositTypeEntity>().HasMany( dt => dt.UserDeposits ).WithOne( ud => ud.DepositType )
                                                   .HasForeignKey( ud => ud.DepositTypeId ).OnDelete( DeleteBehavior.Cascade );

            //User Deposits - Credits settings.
            modelBuilder.Entity<UserCreditEntity>().ToTable( "UserCredits" ).HasKey( p => p.Id );
            modelBuilder.Entity<UserCreditEntity>().Property( p => p.StartDate ).HasDefaultValueSql( "getutcdate()" ).IsRequired();
            modelBuilder.Entity<UserCreditEntity>().Property( p => p.FinishDate ).IsRequired();
            modelBuilder.Entity<UserCreditEntity>().Property( p => p.StartSum ).IsRequired();
            modelBuilder.Entity<UserCreditEntity>().Property( p => p.DebtBalance ).IsRequired();
            modelBuilder.Entity<UserCreditEntity>().Property( p => p.IsRepaid ).IsRequired();
            modelBuilder.Entity<UserCreditEntity>().HasOne( uc => uc.BankAccount ).WithMany( ba => ba.UserCredits )
                                                   .HasForeignKey( uc => uc.BankAccountId ).OnDelete( DeleteBehavior.Cascade );

            modelBuilder.Entity<UserDepositEntity>().ToTable( "UserDeposits" ).HasKey( p => p.Id );
            modelBuilder.Entity<UserDepositEntity>().Property( p => p.StartDate ).HasDefaultValueSql( "getutcdate()" ).IsRequired();
            modelBuilder.Entity<UserDepositEntity>().Property( p => p.FinishDate ).IsRequired();
            modelBuilder.Entity<UserDepositEntity>().Property( p => p.StartSum ).IsRequired();
            modelBuilder.Entity<UserDepositEntity>().Property( p => p.CurrentBalance ).IsRequired();
            modelBuilder.Entity<UserDepositEntity>().Property( p => p.IsPaid ).IsRequired();
            modelBuilder.Entity<UserDepositEntity>().HasOne( ud => ud.BankAccount ).WithMany( ba => ba.UserDeposits )
                                                   .HasForeignKey( ud => ud.BankAccountId ).OnDelete( DeleteBehavior.Cascade );
        }
    }
}
