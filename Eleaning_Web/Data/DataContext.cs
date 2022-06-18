using Microsoft.EntityFrameworkCore;
using Eleaning_Web.Model;
namespace Eleaning_Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Eleaning_Web.Model.Answer>? Answer { get; set; }

        
    }
}
