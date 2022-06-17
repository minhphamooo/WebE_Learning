using Microsoft.EntityFrameworkCore;
namespace Eleaning_Web.Model
{
    public class DBContext : DbContext
    {
        public DBContext()
        {
        }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DBContext(DbContextOptions options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ResultExam> ResultExams { get; set; }
        public DbSet<LearningResult> LearningResults { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TestSchedule> TestSchedules { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ContentTest> ContentTests { get; set; }
       
    }
}
