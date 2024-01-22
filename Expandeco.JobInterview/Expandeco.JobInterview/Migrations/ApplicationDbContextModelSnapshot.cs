﻿// <auto-generated />
using System;
using Expandeco.JobInterview.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Expandeco.JobInterview.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Expandeco.JobInterview.Data.Deadline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DeadlineDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeadlineDateTimeString")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ExpiredDeadline")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Deadline");
                });

            modelBuilder.Entity("Expandeco.JobInterview.Data.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Angličtina"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Slovenčina"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Čeština"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Nemčina"
                        });
                });

            modelBuilder.Entity("Expandeco.JobInterview.Data.Translation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AssignedToId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CreatedById")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DeadlineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DeadlineString")
                        .HasColumnType("TEXT");

                    b.Property<int>("SourceLanguageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetLanguageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TranslatedText")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssignedToId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DeadlineId");

                    b.HasIndex("SourceLanguageId");

                    b.HasIndex("TargetLanguageId");

                    b.ToTable("Translations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssignedToId = 5,
                            CreatedById = 9,
                            SourceLanguageId = 1,
                            TargetLanguageId = 3,
                            Text = "Aut aliquid nihil modi.\nReiciendis repudiandae labore rem iusto in ipsam.\nItaque beatae accusantium atque qui ex hic voluptas.\nEt magni ratione omnis et.\nOfficiis dolore dolores.",
                            Title = "nemo incidunt necessitatibus"
                        },
                        new
                        {
                            Id = 2,
                            AssignedToId = 2,
                            CreatedById = 9,
                            SourceLanguageId = 1,
                            TargetLanguageId = 4,
                            Text = "Et pariatur et soluta esse. Beatae dolores nisi velit eligendi inventore nulla. Autem iste suscipit. Illo qui ipsa neque sapiente. Iure provident voluptas.",
                            Title = "aspernatur totam id"
                        },
                        new
                        {
                            Id = 3,
                            AssignedToId = 5,
                            CreatedById = 10,
                            SourceLanguageId = 2,
                            TargetLanguageId = 4,
                            Text = "Voluptas id quia inventore.\nFugiat aut consequatur.\nVitae et et eos nihil laboriosam laboriosam.\nTotam ab inventore exercitationem corporis eum qui delectus blanditiis et.\nDolor et deleniti.\nDolore cumque blanditiis temporibus.",
                            Title = "repellendus necessitatibus excepturi"
                        },
                        new
                        {
                            Id = 4,
                            CreatedById = 8,
                            SourceLanguageId = 1,
                            TargetLanguageId = 3,
                            Text = "alias",
                            Title = "aperiam veritatis eaque"
                        },
                        new
                        {
                            Id = 5,
                            CreatedById = 9,
                            SourceLanguageId = 2,
                            TargetLanguageId = 3,
                            Text = "omnis",
                            Title = "voluptatum est minus"
                        },
                        new
                        {
                            Id = 6,
                            CreatedById = 9,
                            SourceLanguageId = 1,
                            TargetLanguageId = 4,
                            Text = "Eum nostrum ut libero possimus.",
                            Title = "beatae quo quia"
                        },
                        new
                        {
                            Id = 7,
                            CreatedById = 10,
                            SourceLanguageId = 2,
                            TargetLanguageId = 4,
                            Text = "Repellendus ipsa quia et sed.",
                            Title = "tenetur quod harum"
                        },
                        new
                        {
                            Id = 8,
                            AssignedToId = 7,
                            CreatedById = 8,
                            SourceLanguageId = 1,
                            TargetLanguageId = 4,
                            Text = "sit",
                            Title = "repudiandae harum ut"
                        },
                        new
                        {
                            Id = 9,
                            CreatedById = 9,
                            SourceLanguageId = 2,
                            TargetLanguageId = 4,
                            Text = "Soluta delectus nesciunt quia libero in possimus omnis corrupti est.",
                            Title = "quis vero praesentium"
                        },
                        new
                        {
                            Id = 10,
                            CreatedById = 8,
                            SourceLanguageId = 1,
                            TargetLanguageId = 4,
                            Text = "Fugit necessitatibus velit iure porro provident. Quo asperiores repellat nobis ratione deserunt magni qui. Molestiae voluptas quos voluptas sequi. Perspiciatis ab ipsum tempore.",
                            Title = "perferendis voluptatum ea"
                        });
                });

            modelBuilder.Entity("Expandeco.JobInterview.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bohdan Šidlo",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Aurélia Ďuricová",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bernard Slovák",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Denis Turčok",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "Nataša Pelikánová",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Albín Ďuriš",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Darina Jurkovičová",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Laura Rybníčeková",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 9,
                            Name = "Ferdinand Mojžiš",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "Hugo Finka",
                            TypeId = 3
                        });
                });

            modelBuilder.Entity("Expandeco.JobInterview.Data.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Manažér"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Prekladateľ"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Klient"
                        });
                });

            modelBuilder.Entity("Expandeco.JobInterview.Data.Translation", b =>
                {
                    b.HasOne("Expandeco.JobInterview.Data.User", "AssignedTo")
                        .WithMany()
                        .HasForeignKey("AssignedToId");

                    b.HasOne("Expandeco.JobInterview.Data.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Expandeco.JobInterview.Data.Deadline", "Deadline")
                        .WithMany()
                        .HasForeignKey("DeadlineId");

                    b.HasOne("Expandeco.JobInterview.Data.Language", "SourceLanguage")
                        .WithMany()
                        .HasForeignKey("SourceLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Expandeco.JobInterview.Data.Language", "TargetLanguage")
                        .WithMany()
                        .HasForeignKey("TargetLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedTo");

                    b.Navigation("CreatedBy");

                    b.Navigation("Deadline");

                    b.Navigation("SourceLanguage");

                    b.Navigation("TargetLanguage");
                });

            modelBuilder.Entity("Expandeco.JobInterview.Data.User", b =>
                {
                    b.HasOne("Expandeco.JobInterview.Data.UserType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
