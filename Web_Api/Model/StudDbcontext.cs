using Microsoft.EntityFrameworkCore;

namespace Web_Api.Model
{
    public class StudDbcontext:DbContext
    {
        public StudDbcontext()
        {
        }

        public StudDbcontext(DbContextOptions<StudDbcontext> options):base(options) 
        { 

        }

        public DbSet<Student>Students { get; set; }

    }
}
