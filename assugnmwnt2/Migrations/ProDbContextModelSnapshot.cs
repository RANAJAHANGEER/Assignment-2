﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assugnmwnt2.Data;

#nullable disable

namespace assugnmwnt2.Migrations
{
    [DbContext(typeof(ProDbContext))]
    partial class ProDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("assugnmwnt2.Data.Product", b =>
                {
                    b.Property<int>("pro_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pro_id"));

                    b.Property<string>("pro_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pro_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pro_id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}