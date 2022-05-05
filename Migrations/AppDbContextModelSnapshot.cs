﻿// <auto-generated />
using CustomerPro.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerPro.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CustomerPro.Data.Model.Category", b =>
                {
                    b.Property<int>("Cat_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cat_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cat_Id");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("CustomerPro.Data.Model.Subject", b =>
                {
                    b.Property<int>("Sub_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cat_Id")
                        .HasColumnType("int");

                    b.Property<string>("Sub_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sub_Id");

                    b.HasIndex("Cat_Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("CustomerPro.Data.Model.Subject", b =>
                {
                    b.HasOne("CustomerPro.Data.Model.Category", "Category")
                        .WithMany("Subject")
                        .HasForeignKey("Cat_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CustomerPro.Data.Model.Category", b =>
                {
                    b.Navigation("Subject");
                });
#pragma warning restore 612, 618
        }
    }
}