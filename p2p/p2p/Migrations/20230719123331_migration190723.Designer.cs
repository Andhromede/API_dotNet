﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using p2pAPI.Models;

#nullable disable

namespace p2p.Migrations
{
    [DbContext(typeof(P2PContext))]
    [Migration("20230719123331_migration190723")]
    partial class migration190723
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ChapterLesson", b =>
                {
                    b.Property<int>("Chaptersid")
                        .HasColumnType("integer");

                    b.Property<int>("Lessonsid")
                        .HasColumnType("integer");

                    b.HasKey("Chaptersid", "Lessonsid");

                    b.HasIndex("Lessonsid");

                    b.ToTable("ChapterLesson");
                });

            modelBuilder.Entity("ChapterTag", b =>
                {
                    b.Property<int>("Chaptersid")
                        .HasColumnType("integer");

                    b.Property<int>("Tagsid")
                        .HasColumnType("integer");

                    b.HasKey("Chaptersid", "Tagsid");

                    b.HasIndex("Tagsid");

                    b.ToTable("ChapterTag");
                });

            modelBuilder.Entity("ChapterTraining", b =>
                {
                    b.Property<int>("Chaptersid")
                        .HasColumnType("integer");

                    b.Property<int>("Trainingsid")
                        .HasColumnType("integer");

                    b.HasKey("Chaptersid", "Trainingsid");

                    b.HasIndex("Trainingsid");

                    b.ToTable("ChapterTraining");
                });

            modelBuilder.Entity("p2p.Models.Chapter", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("Duration")
                        .HasColumnType("integer");

                    b.Property<bool>("Is_active")
                        .HasColumnType("boolean");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("PersonId");

                    b.ToTable("Chapter");
                });

            modelBuilder.Entity("p2p.Models.Lesson", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<bool>("Is_active")
                        .HasColumnType("boolean");

                    b.Property<int>("TagId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("TagId");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("p2p.Models.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Adress")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("Is_active")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("RoleId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("p2p.Models.Person_Lesson", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("Is_active")
                        .HasColumnType("boolean");

                    b.Property<bool>("Is_validate")
                        .HasColumnType("boolean");

                    b.Property<int>("LessonId")
                        .HasColumnType("integer");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("LessonId");

                    b.HasIndex("PersonId");

                    b.ToTable("Person_Lesson");
                });

            modelBuilder.Entity("p2p.Models.Person_Training", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("Is_active")
                        .HasColumnType("boolean");

                    b.Property<bool>("Is_author")
                        .HasColumnType("boolean");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<int>("TrainingId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("PersonId");

                    b.HasIndex("TrainingId");

                    b.ToTable("Person_Training");
                });

            modelBuilder.Entity("p2p.Models.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("Is_active")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("p2p.Models.Tag", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("Is_active")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("p2p.Models.Training", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("Is_active")
                        .HasColumnType("boolean");

                    b.Property<int>("TagId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("TagId");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("ChapterLesson", b =>
                {
                    b.HasOne("p2p.Models.Chapter", null)
                        .WithMany()
                        .HasForeignKey("Chaptersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("p2p.Models.Lesson", null)
                        .WithMany()
                        .HasForeignKey("Lessonsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChapterTag", b =>
                {
                    b.HasOne("p2p.Models.Chapter", null)
                        .WithMany()
                        .HasForeignKey("Chaptersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("p2p.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("Tagsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChapterTraining", b =>
                {
                    b.HasOne("p2p.Models.Chapter", null)
                        .WithMany()
                        .HasForeignKey("Chaptersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("p2p.Models.Training", null)
                        .WithMany()
                        .HasForeignKey("Trainingsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("p2p.Models.Chapter", b =>
                {
                    b.HasOne("p2p.Models.Person", "Person")
                        .WithMany("Chapters")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("p2p.Models.Lesson", b =>
                {
                    b.HasOne("p2p.Models.Tag", "Tag")
                        .WithMany("Lessons")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("p2p.Models.Person", b =>
                {
                    b.HasOne("p2p.Models.Role", "Role")
                        .WithMany("Persons")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("p2p.Models.Person_Lesson", b =>
                {
                    b.HasOne("p2p.Models.Lesson", "Lesson")
                        .WithMany("Person_Lessons")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("p2p.Models.Person", "Person")
                        .WithMany("Person_Lessons")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("p2p.Models.Person_Training", b =>
                {
                    b.HasOne("p2p.Models.Person", "Person")
                        .WithMany("Person_Trainings")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("p2p.Models.Training", "Training")
                        .WithMany("Person_Trainings")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("p2p.Models.Training", b =>
                {
                    b.HasOne("p2p.Models.Tag", "Tag")
                        .WithMany("Trainings")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("p2p.Models.Lesson", b =>
                {
                    b.Navigation("Person_Lessons");
                });

            modelBuilder.Entity("p2p.Models.Person", b =>
                {
                    b.Navigation("Chapters");

                    b.Navigation("Person_Lessons");

                    b.Navigation("Person_Trainings");
                });

            modelBuilder.Entity("p2p.Models.Role", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("p2p.Models.Tag", b =>
                {
                    b.Navigation("Lessons");

                    b.Navigation("Trainings");
                });

            modelBuilder.Entity("p2p.Models.Training", b =>
                {
                    b.Navigation("Person_Trainings");
                });
#pragma warning restore 612, 618
        }
    }
}
