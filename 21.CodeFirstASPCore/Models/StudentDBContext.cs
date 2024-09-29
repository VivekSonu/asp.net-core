using Microsoft.EntityFrameworkCore;

namespace _20.CodeFirstASPCore.Models
{
    public class StudentDBContext:DbContext
    {

        //DbContextOptions instance carries configuration information such as the connection string,database provider to use etc.
        public StudentDBContext(DbContextOptions options):base(options) 
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
