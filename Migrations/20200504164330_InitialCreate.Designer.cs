﻿// <auto-generated />
using System;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final_Project_Alpha.Migrations
{
    [DbContext(typeof(GameDbContext))]
    [Migration("20200504164330_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("FinalProject.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GameConsole")
                        .HasColumnType("TEXT");

                    b.Property<string>("GameTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.HasKey("GameId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("FinalProject.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GameId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Publishing_Company")
                        .HasColumnType("TEXT");

                    b.HasKey("PublisherId");

                    b.HasIndex("GameId");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("FinalProject.Models.Publisher", b =>
                {
                    b.HasOne("FinalProject.Models.Game", "Game")
                        .WithMany("Publisher")
                        .HasForeignKey("GameId");
                });
#pragma warning restore 612, 618
        }
    }
}