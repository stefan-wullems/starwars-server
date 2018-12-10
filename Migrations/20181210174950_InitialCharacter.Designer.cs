﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using starwars_browser_server.Models;

namespace starwarsbrowserserver.Migrations
{
    [DbContext(typeof(CharacterContext))]
    [Migration("20181210174950_InitialCharacter")]
    partial class InitialCharacter
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("starwars_browser_server.Models.Character", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("birth_year");

                    b.Property<string>("eye_color");

                    b.Property<string[]>("films");

                    b.Property<string>("gender");

                    b.Property<string>("hair_color");

                    b.Property<string>("height");

                    b.Property<string>("homeworld");

                    b.Property<string>("mass");

                    b.Property<string>("name");

                    b.Property<string>("skin_color");

                    b.Property<string[]>("species");

                    b.Property<string[]>("starships");

                    b.Property<string[]>("vehicles");

                    b.HasKey("id");

                    b.ToTable("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
