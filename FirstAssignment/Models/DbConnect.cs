using Microsoft.EntityFrameworkCore;

namespace FirstAssignment.Models
{
    public class DbConnect:DbContext
    {
        public string con = "Server=LORDS-EYE;Database=FirstAssignment;Trusted_Connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(con);
        }
        public DbSet<Customer> customerTB { get; set; }
        public DbSet<Product> productTB { get; set; }

    }
}
