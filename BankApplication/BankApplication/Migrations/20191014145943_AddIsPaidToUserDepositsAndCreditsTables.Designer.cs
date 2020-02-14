﻿// <auto-generated />
using System;
using BankApplication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankApplication.Migrations
{
    [DbContext(typeof(BankDbContext))]
    [Migration("20191014145943_AddIsPaidToUserDepositsAndCreditsTables")]
    partial class AddIsPaidToUserDepositsAndCreditsTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankApplication.Entities.BankAccountEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Currency");

                    b.Property<bool>("IsFrozen");

                    b.Property<decimal>("MoneyCount");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("BankApplication.Entities.CreditCardEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankAccountId");

                    b.Property<int>("CardType");

                    b.Property<DateTimeOffset>("ExpirationDate");

                    b.Property<string>("PIN")
                        .IsRequired()
                        .HasMaxLength(4);

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.ToTable("CreditCards");
                });

            modelBuilder.Entity("BankApplication.Entities.CreditTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreditTitle")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<double>("InterestRate");

                    b.Property<int>("PayoutPeriod");

                    b.Property<int>("PercentType");

                    b.HasKey("Id");

                    b.ToTable("CreditTypes");
                });

            modelBuilder.Entity("BankApplication.Entities.DepositTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepositTitle")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<double>("InterestRate");

                    b.Property<int>("PayoutPeriod");

                    b.Property<int>("PercentType");

                    b.HasKey("Id");

                    b.ToTable("DepositTypes");
                });

            modelBuilder.Entity("BankApplication.Entities.UserCreditEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankAccountId");

                    b.Property<int>("CreditTypeId");

                    b.Property<decimal>("DebtBalance");

                    b.Property<DateTimeOffset>("FinishDate");

                    b.Property<bool>("IsRepaid");

                    b.Property<DateTimeOffset>("StartDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<decimal>("StartSum");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.HasIndex("CreditTypeId");

                    b.ToTable("UserCredits");
                });

            modelBuilder.Entity("BankApplication.Entities.UserDepositEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankAccountId");

                    b.Property<decimal>("CurrentBalance");

                    b.Property<int>("DepositTypeId");

                    b.Property<DateTimeOffset>("FinishDate");

                    b.Property<bool>("IsPaid");

                    b.Property<DateTimeOffset>("StartDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<decimal>("StartSum");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.HasIndex("DepositTypeId");

                    b.ToTable("UserDeposits");
                });

            modelBuilder.Entity("BankApplication.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("BirthdayDate");

                    b.Property<string>("EmailAdress")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<DateTimeOffset>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BankApplication.Entities.BankAccountEntity", b =>
                {
                    b.HasOne("BankApplication.Entities.UserEntity", "User")
                        .WithMany("BankAccounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BankApplication.Entities.CreditCardEntity", b =>
                {
                    b.HasOne("BankApplication.Entities.BankAccountEntity", "BankAccount")
                        .WithMany("CreditCards")
                        .HasForeignKey("BankAccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BankApplication.Entities.UserCreditEntity", b =>
                {
                    b.HasOne("BankApplication.Entities.BankAccountEntity", "BankAccount")
                        .WithMany("UserCredits")
                        .HasForeignKey("BankAccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BankApplication.Entities.CreditTypeEntity", "CreditType")
                        .WithMany("UserCredits")
                        .HasForeignKey("CreditTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BankApplication.Entities.UserDepositEntity", b =>
                {
                    b.HasOne("BankApplication.Entities.BankAccountEntity", "BankAccount")
                        .WithMany("UserDeposits")
                        .HasForeignKey("BankAccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BankApplication.Entities.DepositTypeEntity", "DepositType")
                        .WithMany("UserDeposits")
                        .HasForeignKey("DepositTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
