﻿// <auto-generated />
using System;
using EduPulse.Domain.Enums;
using EduPulse.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EduPulse.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(EduPulseDbContext))]
    partial class EduPulseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "test_status", new[] { "scheduled", "opened", "closed" });
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EduPulse.Domain.Entities.AnswerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("QuestionEntityId")
                        .HasColumnType("uuid")
                        .HasColumnName("question_entity_id");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_answer_entity");

                    b.HasIndex("QuestionEntityId")
                        .HasDatabaseName("ix_answer_entity_question_entity_id");

                    b.ToTable("answer_entity", (string)null);
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.GroupEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("InstituteId")
                        .HasColumnType("uuid")
                        .HasColumnName("institute_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_groups");

                    b.HasIndex("InstituteId")
                        .HasDatabaseName("ix_groups_institute_id");

                    b.HasIndex("Title")
                        .HasDatabaseName("ix_groups_title");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("Title"), "btree");

                    b.ToTable("groups", (string)null);
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.InstituteEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("code");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_institute_entity");

                    b.ToTable("institute_entity", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("94bc1a39-9a8a-4af8-b683-4eb50fa2a29c"),
                            Code = "ІДА",
                            Title = "Адміністрування, державного управління та професійного розвитку інститут"
                        },
                        new
                        {
                            Id = new Guid("25ec0c5a-83b0-445b-9d74-be8dc9d09be3"),
                            Code = "ІАРД",
                            Title = "Архітектури та дизайну інститут"
                        },
                        new
                        {
                            Id = new Guid("19fba6ad-4004-4473-8eb0-a732ec74f37a"),
                            Code = "ІБІС",
                            Title = "Будівництва та інженерних систем інститут"
                        },
                        new
                        {
                            Id = new Guid("6a59cc1f-62b8-412e-a81e-99b803680faa"),
                            Code = "ІГДГ",
                            Title = "Геодезії інститут"
                        },
                        new
                        {
                            Id = new Guid("c003fabc-36d6-41bc-a51d-dc757ab3fd31"),
                            Code = "ІГСН",
                            Title = "Гуманітарних та соціальних наук інститут"
                        },
                        new
                        {
                            Id = new Guid("a4836b32-047c-4458-88ab-0ea487fb6133"),
                            Code = "ІНЕМ",
                            Title = "Економіки і менеджменту інститут"
                        },
                        new
                        {
                            Id = new Guid("11b429a9-0c4e-439a-8e1f-29050711b834"),
                            Code = "ІЕСК",
                            Title = "Енергетики та систем керування інститут"
                        },
                        new
                        {
                            Id = new Guid("21d23eeb-211c-448d-a579-e3d9c27c3993"),
                            Code = "КНІ",
                            Title = "Комп'ютерних наук та інформаційних технологій"
                        },
                        new
                        {
                            Id = new Guid("3bfb8b21-5d35-4e79-933d-3aa43bd60f84"),
                            Code = "ІКТА",
                            Title = "Комп'ютерних технологій, автоматики та метрології інститут"
                        },
                        new
                        {
                            Id = new Guid("94f10cc4-14de-4f78-82f0-0bac3b132fb7"),
                            Code = "ІМІТ",
                            Title = "Механічної інженерії та транспорту інститут"
                        },
                        new
                        {
                            Id = new Guid("486e68b1-f5bd-4883-a554-302875122f23"),
                            Code = "ІППО",
                            Title = "Права, психології та інноваційної освіти інститут"
                        },
                        new
                        {
                            Id = new Guid("7a8b43b9-ef9f-4f76-a9a0-98fbb01f8081"),
                            Code = "ІМФН",
                            Title = "Прикладної математики та фундаментальних наук інститут"
                        },
                        new
                        {
                            Id = new Guid("18145af2-be3c-4aa5-bd4f-5a03a81c0a0d"),
                            Code = "ІППТ",
                            Title = "Просторового планування та перспективних технологій інститут"
                        },
                        new
                        {
                            Id = new Guid("94c45bb7-6185-4cb2-a487-ee183e42d947"),
                            Code = "ІСТР",
                            Title = "Сталого розвитку і ім. В.Чорновола інститут"
                        },
                        new
                        {
                            Id = new Guid("7da3338c-b618-4ad0-919c-b8699a8c0c49"),
                            Code = "ІТРЕ",
                            Title = "Телекомунікацій, радіоелектроніки та електронної техніки інститут"
                        },
                        new
                        {
                            Id = new Guid("fd644263-a201-4577-ab89-7ae92d4ad73e"),
                            Code = "ІХХТ",
                            Title = "Хімії та хімічних технологій інститут"
                        });
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.QuestionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("CorrectAnswerId")
                        .HasColumnType("uuid")
                        .HasColumnName("correct_answer_id");

                    b.Property<Guid?>("TestEntityId")
                        .HasColumnType("uuid")
                        .HasColumnName("test_entity_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_question_entity");

                    b.HasIndex("TestEntityId")
                        .HasDatabaseName("ix_question_entity_test_entity_id");

                    b.ToTable("question_entity", (string)null);
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.StudentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<string>("Avatar")
                        .HasColumnType("text")
                        .HasColumnName("avatar");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("full_name");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uuid")
                        .HasColumnName("group_id");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<Guid?>("SubjectEntityId")
                        .HasColumnType("uuid")
                        .HasColumnName("subject_entity_id");

                    b.HasKey("Id")
                        .HasName("pk_student_entity");

                    b.HasIndex("Email")
                        .HasDatabaseName("ix_student_entity_email");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("Email"), "btree");

                    b.HasIndex("FullName")
                        .HasDatabaseName("ix_student_entity_full_name");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("FullName"), "btree");

                    b.HasIndex("GroupId")
                        .HasDatabaseName("ix_student_entity_group_id");

                    b.HasIndex("SubjectEntityId")
                        .HasDatabaseName("ix_student_entity_subject_entity_id");

                    b.ToTable("student_entity", (string)null);
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.SubjectEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_subjects");

                    b.ToTable("subjects", (string)null);
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.TeacherEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Avatar")
                        .HasColumnType("text")
                        .HasColumnName("avatar");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("full_name");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.HasKey("Id")
                        .HasName("pk_teachers");

                    b.ToTable("teachers", (string)null);
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.TestEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("ClosesAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("closes_at");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTimeOffset>("OpensAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("opens_at");

                    b.Property<TestStatus>("Status")
                        .HasColumnType("test_status")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_tests");

                    b.HasIndex("Title")
                        .HasDatabaseName("ix_tests_title");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("Title"), "btree");

                    b.ToTable("tests", (string)null);
                });

            modelBuilder.Entity("EduPulse.Infrastructure.Entities.CentrifugoOutboxEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("method");

                    b.Property<int>("Partition")
                        .HasColumnType("integer")
                        .HasColumnName("partition");

                    b.Property<string>("Payload")
                        .IsRequired()
                        .HasColumnType("jsonb")
                        .HasColumnName("payload");

                    b.HasKey("Id")
                        .HasName("pk_centrifugo_outbox");

                    b.ToTable("centrifugo_outbox", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("GroupEntitySubjectEntity", b =>
                {
                    b.Property<Guid>("GroupsId")
                        .HasColumnType("uuid")
                        .HasColumnName("groups_id");

                    b.Property<Guid>("SubjectsId")
                        .HasColumnType("uuid")
                        .HasColumnName("subjects_id");

                    b.HasKey("GroupsId", "SubjectsId")
                        .HasName("pk_group_entity_subject_entity");

                    b.HasIndex("SubjectsId")
                        .HasDatabaseName("ix_group_entity_subject_entity_subjects_id");

                    b.ToTable("group_entity_subject_entity", (string)null);
                });

            modelBuilder.Entity("GroupEntityTeacherEntity", b =>
                {
                    b.Property<Guid>("GroupsId")
                        .HasColumnType("uuid")
                        .HasColumnName("groups_id");

                    b.Property<Guid>("TeachersId")
                        .HasColumnType("uuid")
                        .HasColumnName("teachers_id");

                    b.HasKey("GroupsId", "TeachersId")
                        .HasName("pk_group_entity_teacher_entity");

                    b.HasIndex("TeachersId")
                        .HasDatabaseName("ix_group_entity_teacher_entity_teachers_id");

                    b.ToTable("group_entity_teacher_entity", (string)null);
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.AnswerEntity", b =>
                {
                    b.HasOne("EduPulse.Domain.Entities.QuestionEntity", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionEntityId")
                        .HasConstraintName("fk_answer_entity_question_entity_question_entity_id");
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.GroupEntity", b =>
                {
                    b.HasOne("EduPulse.Domain.Entities.InstituteEntity", "Institute")
                        .WithMany()
                        .HasForeignKey("InstituteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_groups_institute_entity_institute_id");

                    b.Navigation("Institute");
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.QuestionEntity", b =>
                {
                    b.HasOne("EduPulse.Domain.Entities.TestEntity", null)
                        .WithMany("Questions")
                        .HasForeignKey("TestEntityId")
                        .HasConstraintName("fk_question_entity_tests_test_entity_id");
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.StudentEntity", b =>
                {
                    b.HasOne("EduPulse.Domain.Entities.GroupEntity", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_student_entity_groups_group_id");

                    b.HasOne("EduPulse.Domain.Entities.SubjectEntity", null)
                        .WithMany("Teachers")
                        .HasForeignKey("SubjectEntityId")
                        .HasConstraintName("fk_student_entity_subjects_subject_entity_id");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("GroupEntitySubjectEntity", b =>
                {
                    b.HasOne("EduPulse.Domain.Entities.GroupEntity", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_group_entity_subject_entity_groups_groups_id");

                    b.HasOne("EduPulse.Domain.Entities.SubjectEntity", null)
                        .WithMany()
                        .HasForeignKey("SubjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_group_entity_subject_entity_subjects_subjects_id");
                });

            modelBuilder.Entity("GroupEntityTeacherEntity", b =>
                {
                    b.HasOne("EduPulse.Domain.Entities.GroupEntity", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_group_entity_teacher_entity_groups_groups_id");

                    b.HasOne("EduPulse.Domain.Entities.TeacherEntity", null)
                        .WithMany()
                        .HasForeignKey("TeachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_group_entity_teacher_entity_teachers_teachers_id");
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.GroupEntity", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.QuestionEntity", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.SubjectEntity", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.TestEntity", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
