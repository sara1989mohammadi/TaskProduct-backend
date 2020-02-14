﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskProducts.Models;

namespace TaskProducts.Migrations
{
    [DbContext(typeof(ProductsContext))]
    partial class ProductsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskProducts.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<string>("DriverId");

                    b.Property<string>("ProductCategory");

                    b.Property<string>("ProductName");

                    b.Property<string>("Size");

                    b.Property<string>("URL");

                    b.Property<string>("VendorContact");

                    b.Property<string>("Version");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TaskProducts.Models.ProductsReleaseDate", b =>
                {
                    b.Property<int>("ProductsReleaseDateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId");

                    b.Property<string>("ReleasedOn");

                    b.HasKey("ProductsReleaseDateId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductsReleaseDates");
                });

            modelBuilder.Entity("TaskProducts.Models.ProductsReleaseDate", b =>
                {
                    b.HasOne("TaskProducts.Models.Product", "Product")
                        .WithOne("productsReleaseDate")
                        .HasForeignKey("TaskProducts.Models.ProductsReleaseDate", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
