﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectInlog.Infraestrutura.Data;

#nullable disable

namespace ProjectInlog.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241115181856_AddNumeroDePassageiros")]
    partial class AddNumeroDePassageiros
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjectInlog.Core.Entities.Veiculo", b =>
                {
                    b.Property<string>("Chassi")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte>("NumeroPassageiros")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Chassi");

                    b.ToTable("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
