using Entities;
using Microsoft.EntityFrameworkCore;
using ProjectTwoSkillstorm.Entities;


namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }
        public DbSet<Device>? Devices { get; set; }
        public DbSet<PhonePlan> PhonePlans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDevice> UserDevices { get; set; }
        public DbSet<UserPlan> UserPlans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configuration.DeviceConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.PhonePlanConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.UserConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.UserDeviceConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.UserPlanConfiguration());
        }
    }
}
