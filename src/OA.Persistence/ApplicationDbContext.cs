using Microsoft.EntityFrameworkCore;
using OA.Domain.Configurations;
using OA.Domain.Entities;
using OA.Domain.Settings;
using System.Threading.Tasks;

namespace OA.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        AppSettings _appSettings= new AppSettings();

        public ApplicationDbContext()
        {

        }
        
     
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, AppSettings appSettings) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _appSettings = appSettings;
        }

        #region dbSets
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        #endregion

        #region configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);
        }
        #endregion


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder
        //        .UseSqlServer(_appSettings.ConnectionStrings.OArchConnection);
        //    }

        //}

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
