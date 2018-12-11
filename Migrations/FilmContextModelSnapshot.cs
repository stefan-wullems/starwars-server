﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using starwars_browser_server.Models;

namespace starwarsbrowserserver.Migrations
{
    [DbContext(typeof(FilmContext))]
    partial class FilmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("starwars_browser_server.Models.FilmItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string[]>("characters");

                    b.Property<string>("director");

                    b.Property<string>("opening_crawl");

                    b.Property<string[]>("planets");

                    b.Property<string>("producer");

                    b.Property<string>("release_date");

                    b.Property<string[]>("species");

                    b.Property<string[]>("starships");

                    b.Property<string>("title");

                    b.Property<string[]>("vehicles");

                    b.HasKey("id");

                    b.ToTable("Films");
                });
#pragma warning restore 612, 618
        }
    }
}
