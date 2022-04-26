﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParksApi.Models;

namespace NationalParksApi.Migrations
{
    [DbContext(typeof(NationalParksApiContext))]
    [Migration("20220426201112_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NationalParksApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Description = "Yellowstone National Park sits on top of a dormant volcano and is home to more geysers and hot springs than any other place on earth.",
                            Name = "Yellowstone",
                            Region = "West",
                            State = "Wyoming"
                        },
                        new
                        {
                            ParkId = 2,
                            Description = "World renowned for its diversity of plant and animal life, the beauty of its ancient mountains, and the quality of its remnants of Southern Appalachian mountain culture, this is America's most visited national park.",
                            Name = "Great Smokey Mountains",
                            Region = "Southeast",
                            State = "Tennessee"
                        },
                        new
                        {
                            ParkId = 3,
                            Description = "Grand Canyon is considered one of the finest examples of arid-land erosion in the world. Incised by the Colorado River, the canyon is immense, averaging 4,000 feet deep for its entire 277 miles. It is 6,000 feet deep at its deepest point and 18 miles at its widest.",
                            Name = "Grand Canyon",
                            Region = "Southwest",
                            State = "Arizona"
                        },
                        new
                        {
                            ParkId = 4,
                            Description = "Acadia National Park protects the natural beauty of the highest rocky headlands along the Atlantic coastline of the United States, an abundance of habitats, and a rich cultural heritage.",
                            Name = "Acadia",
                            Region = "Northeast",
                            State = "Maine"
                        },
                        new
                        {
                            ParkId = 5,
                            Description = "Yosemite National Park is filled with dramatic scenery including gigantic granite domes, cliffs, rivers, creeks, high waterfalls and Giant Sequoia.",
                            Name = "Yosemite",
                            Region = "West",
                            State = "California"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
