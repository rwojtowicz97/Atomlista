﻿// <auto-generated />
using System;
using Atomlista.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Atomlista.Migrations
{
    [DbContext(typeof(AtomlistContext))]
    [Migration("20200206211056_AddedPeopleCounterToTeams")]
    partial class AddedPeopleCounterToTeams
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Atomlista.Models.Atom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AtomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int?>("BusinessOwnerId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("TechOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("BusinessOwnerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TechOwnerId");

                    b.ToTable("Atoms");
                });

            modelBuilder.Entity("Atomlista.Models.BusinessOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("BusinessOwners");
                });

            modelBuilder.Entity("Atomlista.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("CommentedProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentedProductId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Atomlista.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("People");
                });

            modelBuilder.Entity("Atomlista.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("TechOwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusinessOwnerId");

                    b.HasIndex("TechOwnerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Atomlista.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PeopleCount")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Atomlista.Models.TechOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("TechOwners");
                });

            modelBuilder.Entity("Atomlista.Models.Atom", b =>
                {
                    b.HasOne("Atomlista.Models.BusinessOwner", null)
                        .WithMany("Atoms")
                        .HasForeignKey("BusinessOwnerId");

                    b.HasOne("Atomlista.Models.Product", null)
                        .WithMany("Atoms")
                        .HasForeignKey("ProductId");

                    b.HasOne("Atomlista.Models.TechOwner", null)
                        .WithMany("Atoms")
                        .HasForeignKey("TechOwnerId");
                });

            modelBuilder.Entity("Atomlista.Models.BusinessOwner", b =>
                {
                    b.HasOne("Atomlista.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Atomlista.Models.Comment", b =>
                {
                    b.HasOne("Atomlista.Models.Product", "CommentedProduct")
                        .WithMany("Comments")
                        .HasForeignKey("CommentedProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Atomlista.Models.Person", b =>
                {
                    b.HasOne("Atomlista.Models.Team", null)
                        .WithMany("People")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Atomlista.Models.Product", b =>
                {
                    b.HasOne("Atomlista.Models.BusinessOwner", null)
                        .WithMany("Products")
                        .HasForeignKey("BusinessOwnerId");

                    b.HasOne("Atomlista.Models.TechOwner", null)
                        .WithMany("Products")
                        .HasForeignKey("TechOwnerId");
                });

            modelBuilder.Entity("Atomlista.Models.TechOwner", b =>
                {
                    b.HasOne("Atomlista.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
