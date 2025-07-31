using Microsoft.EntityFrameworkCore;
using RENTACAR.DataContext.Entities;

namespace RENTACAR.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Social> Socials { get; set; }
    }
}
