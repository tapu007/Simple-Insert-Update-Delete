﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Person.DatabaseContext.DatabaseContext;

namespace Person.DatabaseContext.Migrations
{
    [DbContext(typeof(PersonDatabaseContext))]
    partial class PersonDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Person.Models.EntityModels.Personage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhoneNo")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
