﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VendingMachine.DataAccess.SqlServer;

#nullable disable

namespace VendingMachine.DataAccess.SqlServer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("iQuest.VendingMachine.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ColumnId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColumnId = 11,
                            Name = "Apple",
                            Price = 2f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            ColumnId = 12,
                            Name = "Orange",
                            Price = 4f,
                            Quantity = 7
                        },
                        new
                        {
                            Id = 3,
                            ColumnId = 13,
                            Name = "Grape",
                            Price = 2.99f,
                            Quantity = 12
                        },
                        new
                        {
                            Id = 4,
                            ColumnId = 14,
                            Name = "Banana",
                            Price = 2.5f,
                            Quantity = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}