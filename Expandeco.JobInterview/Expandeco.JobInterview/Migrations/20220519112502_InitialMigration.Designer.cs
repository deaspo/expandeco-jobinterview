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
    [Migration("20220519112502_InitialMigration")]
    partial class InitialMigration
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
                            AssignedToId = 5,
                            CreatedById = 8,
                            SourceLanguageId = 2,
                            TargetLanguageId = 3,
                            Text = "Quod atque inventore qui iusto ea atque. Ut dolor architecto iure voluptatem ipsam dolorem minima incidunt. In asperiores earum.",
                            Title = "deleniti asperiores est"
                        },
                        new
                        {
                            Id = 2,
                            CreatedById = 8,
                            SourceLanguageId = 2,
                            TargetLanguageId = 3,
                            Text = "Unde velit ipsa sit et.\nDeleniti esse quo voluptatem reprehenderit qui quas explicabo.\nVoluptatem sit velit voluptas expedita aliquid.\nAnimi nihil quis.\nDolorem perferendis et velit sint quam.",
                            Title = "est quis molestiae"
                        },
                        new
                        {
                            Id = 3,
                            AssignedToId = 6,
                            CreatedById = 8,
                            SourceLanguageId = 2,
                            TargetLanguageId = 3,
                            Text = "Minima temporibus facilis illo.\nRem eaque blanditiis.\nEst repellendus consequatur earum corrupti mollitia suscipit ipsa tenetur necessitatibus.\nTemporibus sint ut ut voluptatem est.\nQuaerat quae fugiat aliquid aliquam.",
                            Title = "ad dolores pariatur"
                        },
                        new
                        {
                            Id = 4,
                            AssignedToId = 3,
                            CreatedById = 8,
                            SourceLanguageId = 2,
                            TargetLanguageId = 3,
                            Text = "Consectetur quidem fugit quo. Cupiditate itaque qui saepe dolorum. Quis voluptas omnis tempore.",
                            Title = "ut qui aliquid"
                        },
                        new
                        {
                            Id = 5,
                            CreatedById = 8,
                            SourceLanguageId = 2,
                            TargetLanguageId = 4,
                            Text = "Repellendus enim consequatur natus sed corrupti et enim. Sit voluptates rerum. Id odit eum blanditiis harum at illum perferendis aliquam reprehenderit. Eaque eos velit omnis. Vel odit magni.",
                            Title = "quia autem non"
                        },
                        new
                        {
                            Id = 6,
                            CreatedById = 9,
                            SourceLanguageId = 1,
                            TargetLanguageId = 3,
                            Text = "Molestias laboriosam quia rem corporis ipsa.\nQuod et eveniet magni non.\nNon aut est cupiditate in nostrum at voluptatem.\nTempora dolor quibusdam ad.\nOdio id quia unde quia veritatis occaecati placeat ab beatae.",
                            Title = "facilis suscipit dicta"
                        },
                        new
                        {
                            Id = 7,
                            AssignedToId = 6,
                            CreatedById = 8,
                            SourceLanguageId = 1,
                            TargetLanguageId = 3,
                            Text = "Non dolor aperiam consequatur nobis iure ut nisi minima fugit. Cum doloremque quae et alias. Ut a accusamus dolor dolor fugiat non a similique.",
                            Title = "eum saepe non"
                        },
                        new
                        {
                            Id = 8,
                            AssignedToId = 3,
                            CreatedById = 10,
                            SourceLanguageId = 1,
                            TargetLanguageId = 4,
                            Text = "Enim eos repellendus nesciunt quia totam itaque id. Et odit officia eum explicabo eos ipsa quis omnis et. Quas at sed magnam quas in earum aspernatur natus eaque. Voluptatem quia ullam quos atque ipsum quo alias. Eveniet autem et voluptas doloremque.",
                            Title = "dolor quidem suscipit"
                        },
                        new
                        {
                            Id = 9,
                            CreatedById = 8,
                            SourceLanguageId = 1,
                            TargetLanguageId = 4,
                            Text = "Maxime sed expedita animi cupiditate quo.\nAt aut nulla eum.",
                            Title = "ut in ex"
                        },
                        new
                        {
                            Id = 10,
                            AssignedToId = 3,
                            CreatedById = 10,
                            SourceLanguageId = 2,
                            TargetLanguageId = 3,
                            Text = "quo",
                            Title = "in omnis sed"
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
                            Name = "Ondrej Kolnik",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bohumil Beňo",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bernard Krajčo",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Patrik Krajíček",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ignác Senko",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Dobromila Lubinová",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Klement Thomka",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Silvester Jánošík",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 9,
                            Name = "Štefánia Liptáková",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "Silvia Dvončová",
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
