﻿// <auto-generated />
using System;
using Atividade_Avaliativa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Atividade_Avaliativa.Migrations
{
    [DbContext(typeof(Atividade_AvaliativaContext))]
    [Migration("20240314110147_Pessoa")]
    partial class Pessoa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Atividade_Avaliativa.Models.Pessoa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_Nascimento");

                    b.Property<string>("Email");

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("ID");

                    b.ToTable("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
