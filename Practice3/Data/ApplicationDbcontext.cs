using Microsoft.EntityFrameworkCore;
using Practice3.Models;

namespace Practice3.Data
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options):base(options)
        {

        }

        public DbSet<Person> personas { get; set; }
    }
}
