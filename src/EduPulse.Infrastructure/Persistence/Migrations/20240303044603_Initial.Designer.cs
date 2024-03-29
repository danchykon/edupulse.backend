﻿// <auto-generated />
using System;
using EduPulse.Domain.Enums;
using EduPulse.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EduPulse.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(EduPulseDbContext))]
    [Migration("20240303044603_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasName("pk_institutes");

                    b.ToTable("institutes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f2ba3629-0d65-42e2-a5ca-19b8b120c52e"),
                            Code = "ІДА",
                            Title = "Адміністрування, державного управління та професійного розвитку інститут"
                        },
                        new
                        {
                            Id = new Guid("9afda503-e2a7-4339-ba32-00057615706f"),
                            Code = "ІАРД",
                            Title = "Архітектури та дизайну інститут"
                        },
                        new
                        {
                            Id = new Guid("c31516c2-6d76-4e6a-98f8-2ff5e364cc86"),
                            Code = "ІБІС",
                            Title = "Будівництва та інженерних систем інститут"
                        },
                        new
                        {
                            Id = new Guid("e666b9f1-e04d-4655-adce-a81e35947e1b"),
                            Code = "ІГДГ",
                            Title = "Геодезії інститут"
                        },
                        new
                        {
                            Id = new Guid("75dc8846-eced-4dbd-b3ec-c6e41bbbf11f"),
                            Code = "ІГСН",
                            Title = "Гуманітарних та соціальних наук інститут"
                        },
                        new
                        {
                            Id = new Guid("2415b863-d4c6-43ed-8c79-0706c9e4b90f"),
                            Code = "ІНЕМ",
                            Title = "Економіки і менеджменту інститут"
                        },
                        new
                        {
                            Id = new Guid("7c474bce-c795-4712-9e8a-be11b747ac2f"),
                            Code = "ІЕСК",
                            Title = "Енергетики та систем керування інститут"
                        },
                        new
                        {
                            Id = new Guid("a6a74f55-087f-489e-9f77-8870390f6f25"),
                            Code = "КНІ",
                            Title = "Комп'ютерних наук та інформаційних технологій"
                        },
                        new
                        {
                            Id = new Guid("882db9a3-c578-4c71-86b2-fa795883f751"),
                            Code = "ІКТА",
                            Title = "Комп'ютерних технологій, автоматики та метрології інститут"
                        },
                        new
                        {
                            Id = new Guid("2be46ae3-4dde-46cb-bffa-6d2e15935e85"),
                            Code = "ІМІТ",
                            Title = "Механічної інженерії та транспорту інститут"
                        },
                        new
                        {
                            Id = new Guid("25c00b2b-25cb-4a96-b51a-40c947d84fe9"),
                            Code = "ІППО",
                            Title = "Права, психології та інноваційної освіти інститут"
                        },
                        new
                        {
                            Id = new Guid("9fdf00b6-727e-49dc-a9da-f98eea388cc2"),
                            Code = "ІМФН",
                            Title = "Прикладної математики та фундаментальних наук інститут"
                        },
                        new
                        {
                            Id = new Guid("48ebf6e4-edaa-4d24-8f69-b6a9c8ec384b"),
                            Code = "ІППТ",
                            Title = "Просторового планування та перспективних технологій інститут"
                        },
                        new
                        {
                            Id = new Guid("5caa07c6-842b-4f5f-a353-4a6493d3ef26"),
                            Code = "ІСТР",
                            Title = "Сталого розвитку і ім. В.Чорновола інститут"
                        },
                        new
                        {
                            Id = new Guid("9ecab6b8-48c2-45bc-bbf6-08ec88fdb34b"),
                            Code = "ІТРЕ",
                            Title = "Телекомунікацій, радіоелектроніки та електронної техніки інститут"
                        },
                        new
                        {
                            Id = new Guid("9f2c16f5-325b-4a09-b283-0b1f14647402"),
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

                    b.Property<int>("Points")
                        .HasColumnType("integer")
                        .HasColumnName("points");

                    b.Property<Guid?>("TestEntityId")
                        .HasColumnType("uuid")
                        .HasColumnName("test_entity_id");

                    b.Property<Guid>("TestId")
                        .HasColumnType("uuid")
                        .HasColumnName("test_id");

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

                    b.HasKey("Id")
                        .HasName("pk_students");

                    b.HasIndex("Email")
                        .HasDatabaseName("ix_students_email");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("Email"), "btree");

                    b.HasIndex("FullName")
                        .HasDatabaseName("ix_students_full_name");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("FullName"), "btree");

                    b.HasIndex("GroupId")
                        .HasDatabaseName("ix_students_group_id");

                    b.ToTable("students", (string)null);
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

            modelBuilder.Entity("EduPulse.Domain.Entities.TeacherGroupEntity", b =>
                {
                    b.Property<Guid>("GroupId")
                        .HasColumnType("uuid")
                        .HasColumnName("group_id");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uuid")
                        .HasColumnName("teacher_id");

                    b.HasKey("GroupId", "TeacherId")
                        .HasName("pk_teacher_groups");

                    b.HasIndex("TeacherId")
                        .HasDatabaseName("ix_teacher_groups_teacher_id");

                    b.ToTable("teacher_groups", (string)null);
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.TeacherSubjectEntity", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uuid")
                        .HasColumnName("subject_id");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uuid")
                        .HasColumnName("teacher_id");

                    b.HasKey("SubjectId", "TeacherId")
                        .HasName("pk_teacher_subjects");

                    b.HasIndex("TeacherId")
                        .HasDatabaseName("ix_teacher_subjects_teacher_id");

                    b.ToTable("teacher_subjects", (string)null);
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

            modelBuilder.Entity("EduPulse.Domain.Entities.UserAnswerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("CorrectValue")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("correct_value");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uuid")
                        .HasColumnName("question_id");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uuid")
                        .HasColumnName("student_id");

                    b.Property<Guid>("TestId")
                        .HasColumnType("uuid")
                        .HasColumnName("test_id");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_user_answers");

                    b.ToTable("user_answers", (string)null);
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
                        .HasConstraintName("fk_groups_institutes_institute_id");

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
                        .HasConstraintName("fk_students_groups_group_id");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.TeacherGroupEntity", b =>
                {
                    b.HasOne("EduPulse.Domain.Entities.GroupEntity", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_teacher_groups_groups_group_id");

                    b.HasOne("EduPulse.Domain.Entities.TeacherEntity", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_teacher_groups_teachers_teacher_id");

                    b.Navigation("Group");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.TeacherSubjectEntity", b =>
                {
                    b.HasOne("EduPulse.Domain.Entities.SubjectEntity", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_teacher_subjects_subjects_subject_id");

                    b.HasOne("EduPulse.Domain.Entities.TeacherEntity", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_teacher_subjects_teachers_teacher_id");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
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

            modelBuilder.Entity("EduPulse.Domain.Entities.GroupEntity", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.QuestionEntity", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("EduPulse.Domain.Entities.TestEntity", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
