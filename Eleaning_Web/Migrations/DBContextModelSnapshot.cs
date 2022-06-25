﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEB_ELEANING.Model;

#nullable disable

namespace WEB_ELEANING.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WEB_ELEANING.Model.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ClassId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.ContentTest", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContentId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("ContentId");

                    b.HasIndex("ExamID");

                    b.HasIndex("SubjectID");

                    b.ToTable("ContentTest");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.DetailClass", b =>
                {
                    b.Property<int>("DetailClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailClassId"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.HasKey("DetailClassId");

                    b.HasIndex("ClassId");

                    b.HasIndex("SemesterId");

                    b.ToTable("DetailClass");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.DetailSubject", b =>
                {
                    b.Property<int>("DetailSubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailSubjectId"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("DetailSubjectId");

                    b.HasIndex("ClassId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("SubjectId");

                    b.ToTable("DetailSubject");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"), 1L, 1);

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameDocument")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("DocumentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.Exam", b =>
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

                    b.Property<string>("NameExam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<string>("TypeExamId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TypeTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExamId");

                    b.HasIndex("TypeExamId");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.LearningResult", b =>
                {
                    b.Property<string>("LRId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("AttendancePoint")
                        .HasColumnType("real");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

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

                    b.Property<float>("SumScoreAvg")
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LRId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("LearningResult");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.Question", b =>
                {
                    b.Property<string>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AnswerA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerCorrect")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.Property<int>("ContentTestContentId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.HasIndex("ContentTestContentId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.ResultExam", b =>
                {
                    b.Property<int>("ResultExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResultExamId"), 1L, 1);

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ResultExamId");

                    b.HasIndex("ExamId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("ResultExam");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.Role", b =>
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

            modelBuilder.Entity("WEB_ELEANING.Model.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleId"), 1L, 1);

                    b.Property<int>("DayLearn")
                        .HasColumnType("int");

                    b.Property<string>("End")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ScheduleName")
                        .HasColumnType("real");

                    b.Property<string>("Start")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ScheduleId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.Semester", b =>
                {
                    b.Property<int>("SemesterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SemesterId"), 1L, 1);

                    b.Property<DateTime>("EndDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("SemesterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDay")
                        .HasColumnType("datetime2");

                    b.HasKey("SemesterId");

                    b.ToTable("Semester");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

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

            modelBuilder.Entity("WEB_ELEANING.Model.TypeExam", b =>
                {
                    b.Property<string>("TypeExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TypeExamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeExamId");

                    b.ToTable("TypeExam");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.ContentTest", b =>
                {
                    b.HasOne("WEB_ELEANING.Model.Exam", "Exam")
                        .WithMany("contentTests")
                        .HasForeignKey("ExamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEB_ELEANING.Model.Subject", "Subject")
                        .WithMany("ContentTest")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.DetailClass", b =>
                {
                    b.HasOne("WEB_ELEANING.Model.Class", "Class")
                        .WithMany("DetailClass")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEB_ELEANING.Model.Semester", "Semester")
                        .WithMany()
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.DetailSubject", b =>
                {
                    b.HasOne("WEB_ELEANING.Model.Class", "Class")
                        .WithMany("DetailSubject")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEB_ELEANING.Model.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEB_ELEANING.Model.Subject", "Subject")
                        .WithMany("DetailSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Schedule");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.Document", b =>
                {
                    b.HasOne("WEB_ELEANING.Model.Subject", "subject")
                        .WithMany("Documents")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("subject");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.Exam", b =>
                {
                    b.HasOne("WEB_ELEANING.Model.TypeExam", null)
                        .WithMany("Exams")
                        .HasForeignKey("TypeExamId");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.LearningResult", b =>
                {
                    b.HasOne("WEB_ELEANING.Model.User", "user")
                        .WithOne("LearningResult")
                        .HasForeignKey("WEB_ELEANING.Model.LearningResult", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.Question", b =>
                {
                    b.HasOne("WEB_ELEANING.Model.ContentTest", "ContentTest")
                        .WithMany("Questions")
                        .HasForeignKey("ContentTestContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContentTest");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.ResultExam", b =>
                {
                    b.HasOne("WEB_ELEANING.Model.Exam", "Exam")
                        .WithOne("ResultExam")
                        .HasForeignKey("WEB_ELEANING.Model.ResultExam", "ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEB_ELEANING.Model.User", "User")
                        .WithMany("ResultExam")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.User", b =>
                {
                    b.HasOne("WEB_ELEANING.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.Class", b =>
                {
                    b.Navigation("DetailClass");

                    b.Navigation("DetailSubject");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.ContentTest", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.Exam", b =>
                {
                    b.Navigation("ResultExam")
                        .IsRequired();

                    b.Navigation("contentTests");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.Subject", b =>
                {
                    b.Navigation("ContentTest");

                    b.Navigation("DetailSubjects");

                    b.Navigation("Documents");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.TypeExam", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("WEB_ELEANING.Model.User", b =>
                {
                    b.Navigation("LearningResult")
                        .IsRequired();

                    b.Navigation("ResultExam");
                });
#pragma warning restore 612, 618
        }
    }
}
