using Microsoft.EntityFrameworkCore;
namespace Eleaning_Web.Model
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<ResultExam> ResultExam { get; set; }
        public DbSet<LearningResult> LearningResult { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<TestSchedule> TestSchedule { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<ContentTest> ContentTest { get; set; }
       
    }
}
