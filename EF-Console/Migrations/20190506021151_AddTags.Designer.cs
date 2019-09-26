﻿// <auto-generated />
using System;
using EF_Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EF_Console.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190506021151_AddTags")]
    partial class AddTags
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("learning")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EF_Console.Entities.Account", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnName("created_time");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("OrganizationId")
                        .HasColumnName("organization_id");

                    b.HasKey("Id")
                        .HasName("pk_account");

                    b.HasIndex("OrganizationId")
                        .HasName("ix_account_organization_id");

                    b.ToTable("account");
                });

            modelBuilder.Entity("EF_Console.Entities.AccountTag", b =>
                {
                    b.Property<string>("AccountId")
                        .HasColumnName("account_id");

                    b.Property<string>("TagId")
                        .HasColumnName("tag_id");

                    b.HasKey("AccountId", "TagId")
                        .HasName("pk_account_tag");

                    b.HasIndex("TagId")
                        .HasName("ix_account_tag_tag_id");

                    b.ToTable("account_tag");
                });

            modelBuilder.Entity("EF_Console.Entities.Organization", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnName("created_time");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_organization");

                    b.ToTable("organization");
                });

            modelBuilder.Entity("EF_Console.Entities.Tag", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_tag");

                    b.ToTable("tag");
                });

            modelBuilder.Entity("EF_Console.Entities.Account", b =>
                {
                    b.HasOne("EF_Console.Entities.Organization", "Organization")
                        .WithMany("OwnAccounts")
                        .HasForeignKey("OrganizationId")
                        .HasConstraintName("fk_account_organization_organization_id");
                });

            modelBuilder.Entity("EF_Console.Entities.AccountTag", b =>
                {
                    b.HasOne("EF_Console.Entities.Account", "Account")
                        .WithMany("OwnAccountTags")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("fk_account_tag_account_account_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EF_Console.Entities.Tag", "Tag")
                        .WithMany("OwnAccountTags")
                        .HasForeignKey("TagId")
                        .HasConstraintName("fk_account_tag_tag_tag_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
