﻿// <auto-generated />
using DungeonApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DungeonApi.Migrations
{
    [DbContext(typeof(DungeonApiContext))]
    partial class DungeonApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DungeonApi.Models.Monster", b =>
                {
                    b.Property<int>("MonsterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MonsterName")
                        .IsRequired();

                    b.HasKey("MonsterId");

                    b.ToTable("Monsters");
                });
#pragma warning restore 612, 618
        }
    }
}
