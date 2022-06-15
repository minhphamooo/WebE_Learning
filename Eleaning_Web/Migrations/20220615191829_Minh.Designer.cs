﻿// <auto-generated />
using System;
using Eleaning_Web.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Eleaning_Web.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20220615191829_Minh")]
    partial class Minh
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Eleaning_Web.Model.Answer", b =>
                {
                    b.Property<string>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("IdExam")
                        .HasColumnType("int");

                    b.Property<bool>("RightWrong")
                        .HasColumnType("bit");

                    b.HasKey("AnswerId");

                    b.HasIndex("ExamId");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Class", b =>
                {
                    b.Property<string>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ClassId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("Eleaning_Web.Model.ContentTest", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContentId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdTest")
                        .HasColumnType("int");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("ContentId");

                    b.HasIndex("TestId");

                    b.ToTable("ContentTest");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"), 1L, 1);

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NameDocument")
                        .HasColumnType("int");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DocumentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<string>("NameExam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("TestScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<string>("TypeTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExamId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TestScheduleId");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("Eleaning_Web.Model.LearningResult", b =>
                {
                    b.Property<string>("LRId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("AttendancePoint")
                        .HasColumnType("real");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<bool>("ResultOfEvaluation")
                        .HasColumnType("bit");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<float>("Score15Minunes")
                        .HasColumnType("real");

                    b.Property<float>("ScoreAvg")
                        .HasColumnType("real");

                    b.Property<float>("ScoreCoefficient2")
                        .HasColumnType("real");

                    b.Property<float>("ScoreCoefficient3")
                        .HasColumnType("real");

                    b.Property<float>("ScoreOralTest")
                        .HasColumnType("real");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("SumScoreAvg")
                        .HasColumnType("real");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LRId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("UserId");

                    b.ToTable("LearningResult");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Question", b =>
                {
                    b.Property<string>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Form")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("QuestionId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("Eleaning_Web.Model.ResultExam", b =>
                {
                    b.Property<string>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DayExam")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("IdExam")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ResultId");

                    b.HasIndex("ExamId");

                    b.HasIndex("UserId");

                    b.ToTable("ResultExam");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleId"), 1L, 1);

                    b.Property<DateTime>("DayLearn")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("ScheduleId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Subject", b =>
                {
                    b.Property<string>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("NameTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TestId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("Eleaning_Web.Model.TestSchedule", b =>
                {
                    b.Property<int>("TestScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestScheduleId"), 1L, 1);

                    b.Property<DateTime>("DayExam")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("TestScheduleId");

                    b.ToTable("TestSchedule");
                });

            modelBuilder.Entity("Eleaning_Web.Model.User", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("ClassId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Answer", b =>
                {
                    b.HasOne("Eleaning_Web.Model.Exam", "exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("exam");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Class", b =>
                {
                    b.HasOne("Eleaning_Web.Model.Subject", "subject")
                        .WithMany("classes")
                        .HasForeignKey("SubjectId");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("Eleaning_Web.Model.ContentTest", b =>
                {
                    b.HasOne("Eleaning_Web.Model.Test", "test")
                        .WithMany()
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("test");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Document", b =>
                {
                    b.HasOne("Eleaning_Web.Model.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Exam", b =>
                {
                    b.HasOne("Eleaning_Web.Model.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.HasOne("Eleaning_Web.Model.TestSchedule", null)
                        .WithMany("Exam")
                        .HasForeignKey("TestScheduleId");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Eleaning_Web.Model.LearningResult", b =>
                {
                    b.HasOne("Eleaning_Web.Model.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.HasOne("Eleaning_Web.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("subject");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Question", b =>
                {
                    b.HasOne("Eleaning_Web.Model.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("Eleaning_Web.Model.ResultExam", b =>
                {
                    b.HasOne("Eleaning_Web.Model.Exam", "exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eleaning_Web.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("exam");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Schedule", b =>
                {
                    b.HasOne("Eleaning_Web.Model.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Test", b =>
                {
                    b.HasOne("Eleaning_Web.Model.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eleaning_Web.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Subject");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Eleaning_Web.Model.User", b =>
                {
                    b.HasOne("Eleaning_Web.Model.Class", null)
                        .WithMany("users")
                        .HasForeignKey("ClassId");

                    b.HasOne("Eleaning_Web.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Class", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("Eleaning_Web.Model.Subject", b =>
                {
                    b.Navigation("classes");
                });

            modelBuilder.Entity("Eleaning_Web.Model.TestSchedule", b =>
                {
                    b.Navigation("Exam");
                });
#pragma warning restore 612, 618
        }
    }
}