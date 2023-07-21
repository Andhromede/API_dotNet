﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using p2pAPI.Models;

#nullable disable

namespace p2p.Migrations
{
    [DbContext(typeof(P2PContext))]
    partial class P2PContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ChapterLesson", b =>
                {
                    b.Property<int>("chaptersid")
                        .HasColumnType("integer");

                    b.Property<int>("lessonsid")
                        .HasColumnType("integer");

                    b.HasKey("chaptersid", "lessonsid");

                    b.HasIndex("lessonsid");

                    b.ToTable("ChapterLesson");
                });

            modelBuilder.Entity("ChapterTag", b =>
                {
                    b.Property<int>("chaptersid")
                        .HasColumnType("integer");

                    b.Property<int>("tagsid")
                        .HasColumnType("integer");

                    b.HasKey("chaptersid", "tagsid");

                    b.HasIndex("tagsid");

                    b.ToTable("ChapterTag");
                });

            modelBuilder.Entity("ChapterTraining", b =>
                {
                    b.Property<int>("chaptersid")
                        .HasColumnType("integer");

                    b.Property<int>("trainingsid")
                        .HasColumnType("integer");

                    b.HasKey("chaptersid", "trainingsid");

                    b.HasIndex("trainingsid");

                    b.ToTable("ChapterTraining");
                });

            modelBuilder.Entity("p2p.Models.Chapter", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("duration")
                        .HasColumnType("integer");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<int>("personId")
                        .HasColumnType("integer");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("personId");

                    b.ToTable("Chapter");
                });

            modelBuilder.Entity("p2p.Models.Lesson", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<int>("tagId")
                        .HasColumnType("integer");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("tagId");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("p2p.Models.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("adress")
                        .HasColumnType("text");

                    b.Property<DateTime?>("birthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("firstName")
                        .HasColumnType("text");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<string>("lastName")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("roleid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("roleid");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("p2p.Models.Person_Lesson", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("isValidate")
                        .HasColumnType("boolean");

                    b.Property<int>("lessonId")
                        .HasColumnType("integer");

                    b.Property<int>("personId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("lessonId");

                    b.HasIndex("personId");

                    b.ToTable("Person_Lesson");
                });

            modelBuilder.Entity("p2p.Models.Person_Training", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("isAuthor")
                        .HasColumnType("boolean");

                    b.Property<int>("personId")
                        .HasColumnType("integer");

                    b.Property<int>("trainingId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("personId");

                    b.HasIndex("trainingId");

                    b.ToTable("Person_Training");
                });

            modelBuilder.Entity("p2p.Models.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
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

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
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

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<int>("tagId")
                        .HasColumnType("integer");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("tagId");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("ChapterLesson", b =>
                {
                    b.HasOne("p2p.Models.Chapter", null)
                        .WithMany()
                        .HasForeignKey("chaptersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("p2p.Models.Lesson", null)
                        .WithMany()
                        .HasForeignKey("lessonsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChapterTag", b =>
                {
                    b.HasOne("p2p.Models.Chapter", null)
                        .WithMany()
                        .HasForeignKey("chaptersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("p2p.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("tagsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChapterTraining", b =>
                {
                    b.HasOne("p2p.Models.Chapter", null)
                        .WithMany()
                        .HasForeignKey("chaptersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("p2p.Models.Training", null)
                        .WithMany()
                        .HasForeignKey("trainingsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("p2p.Models.Chapter", b =>
                {
                    b.HasOne("p2p.Models.Person", "person")
                        .WithMany("chapters")
                        .HasForeignKey("personId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("person");
                });

            modelBuilder.Entity("p2p.Models.Lesson", b =>
                {
                    b.HasOne("p2p.Models.Tag", "tag")
                        .WithMany("lessons")
                        .HasForeignKey("tagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tag");
                });

            modelBuilder.Entity("p2p.Models.Person", b =>
                {
                    b.HasOne("p2p.Models.Role", "role")
                        .WithMany("persons")
                        .HasForeignKey("roleid");

                    b.Navigation("role");
                });

            modelBuilder.Entity("p2p.Models.Person_Lesson", b =>
                {
                    b.HasOne("p2p.Models.Lesson", "lesson")
                        .WithMany("personLessons")
                        .HasForeignKey("lessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("p2p.Models.Person", "person")
                        .WithMany("personLessons")
                        .HasForeignKey("personId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("lesson");

                    b.Navigation("person");
                });

            modelBuilder.Entity("p2p.Models.Person_Training", b =>
                {
                    b.HasOne("p2p.Models.Person", "person")
                        .WithMany("personTrainings")
                        .HasForeignKey("personId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("p2p.Models.Training", "training")
                        .WithMany("personTrainings")
                        .HasForeignKey("trainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("person");

                    b.Navigation("training");
                });

            modelBuilder.Entity("p2p.Models.Training", b =>
                {
                    b.HasOne("p2p.Models.Tag", "tag")
                        .WithMany("trainings")
                        .HasForeignKey("tagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tag");
                });

            modelBuilder.Entity("p2p.Models.Lesson", b =>
                {
                    b.Navigation("personLessons");
                });

            modelBuilder.Entity("p2p.Models.Person", b =>
                {
                    b.Navigation("chapters");

                    b.Navigation("personLessons");

                    b.Navigation("personTrainings");
                });

            modelBuilder.Entity("p2p.Models.Role", b =>
                {
                    b.Navigation("persons");
                });

            modelBuilder.Entity("p2p.Models.Tag", b =>
                {
                    b.Navigation("lessons");

                    b.Navigation("trainings");
                });

            modelBuilder.Entity("p2p.Models.Training", b =>
                {
                    b.Navigation("personTrainings");
                });
#pragma warning restore 612, 618
        }
    }
}
