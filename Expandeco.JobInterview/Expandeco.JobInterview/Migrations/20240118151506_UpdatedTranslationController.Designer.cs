﻿// <auto-generated />
using System;
using Expandeco.JobInterview.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Expandeco.JobInterview.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240118151506_UpdatedTranslationController")]
    partial class UpdatedTranslationController
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

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

                    b.HasIndex("SourceLanguageId");

                    b.HasIndex("TargetLanguageId");

                    b.ToTable("Translations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssignedToId = 3,
                            CreatedById = 10,
                            SourceLanguageId = 1,
                            TargetLanguageId = 4,
                            Text = "Magnam autem quaerat voluptas est.\nEa molestiae quia illo qui.\nVoluptas consequuntur repudiandae soluta modi.\nPerferendis consectetur tempore.\nNobis itaque tempore voluptatum voluptatem quae ratione.\nA sit mollitia sit sunt ipsum eligendi quo veritatis.",
                            Title = "nisi enim perferendis"
                        },
                        new
                        {
                            Id = 2,
                            AssignedToId = 3,
                            CreatedById = 10,
                            SourceLanguageId = 2,
                            TargetLanguageId = 3,
                            Text = "Aut consectetur odit deleniti suscipit adipisci deserunt mollitia dolores.",
                            Title = "eaque exercitationem dolores"
                        },
                        new
                        {
                            Id = 3,
                            AssignedToId = 5,
                            CreatedById = 9,
                            SourceLanguageId = 1,
                            TargetLanguageId = 3,
                            Text = "Quia dolor consequatur ex necessitatibus dolor dolorem in nulla maxime.",
                            Title = "ratione ipsam repudiandae"
                        },
                        new
                        {
                            Id = 4,
                            AssignedToId = 3,
                            CreatedById = 10,
                            SourceLanguageId = 1,
                            TargetLanguageId = 3,
                            Text = "Repellat aspernatur laborum provident omnis. Ab qui error doloribus incidunt quia vitae voluptatem voluptatem. Quis occaecati eius.",
                            Title = "tempore sint molestiae"
                        },
                        new
                        {
                            Id = 5,
                            AssignedToId = 6,
                            CreatedById = 8,
                            SourceLanguageId = 1,
                            TargetLanguageId = 3,
                            Text = "Error error placeat.",
                            Title = "velit qui qui"
                        },
                        new
                        {
                            Id = 6,
                            CreatedById = 9,
                            SourceLanguageId = 1,
                            TargetLanguageId = 3,
                            Text = "Laudantium iusto illo.",
                            Title = "incidunt porro eum"
                        },
                        new
                        {
                            Id = 7,
                            CreatedById = 10,
                            SourceLanguageId = 1,
                            TargetLanguageId = 3,
                            Text = "Distinctio dolores ut occaecati hic odio.",
                            Title = "eos voluptatem error"
                        },
                        new
                        {
                            Id = 8,
                            AssignedToId = 2,
                            CreatedById = 8,
                            SourceLanguageId = 2,
                            TargetLanguageId = 3,
                            Text = "Quia dolorem optio minus.",
                            Title = "aut enim qui"
                        },
                        new
                        {
                            Id = 9,
                            AssignedToId = 5,
                            CreatedById = 9,
                            SourceLanguageId = 2,
                            TargetLanguageId = 4,
                            Text = "Non eius eum.",
                            Title = "quisquam sapiente doloremque"
                        },
                        new
                        {
                            Id = 10,
                            AssignedToId = 2,
                            CreatedById = 9,
                            SourceLanguageId = 2,
                            TargetLanguageId = 3,
                            Text = "Voluptate ipsa inventore tempore accusamus voluptas.\nEst et est maiores accusamus.",
                            Title = "veniam corrupti veritatis"
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

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Vít Sýkora",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cyprián Heretik",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hana Dočolomanská",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ľubica Kostkaová",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "Miloslav Tomko",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ervín Mokroš",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Zuzana Janíková",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Ľuboš Obšut",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 9,
                            Name = "Cyprián Fico",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "Tichomír Maslo",
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

                    b.Navigation("SourceLanguage");

                    b.Navigation("TargetLanguage");
                });
#pragma warning restore 612, 618
        }
    }
}