
namespace TransfloAssesment.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Driver> Drivers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Driver>().HasData(
                new Driver
                {
                    Id = 1,
                    firstName = "Ramadan1",
                    creationDate = DateTime.Now.Date,
                    lastName = "Essam",
                    Email = "Ramadan@gmail.com",
                    phoneNumber = "+128987873",
                    isDeleted = false,
                    

                },
              new Driver
              {
                  Id = 2,
                  firstName = "Ramadan2",
                  creationDate = DateTime.Now.Date,
                  lastName = "Essam",
                  Email = "Ramadan2@gmail.com",
                  phoneNumber = "+1028987873",
                  isDeleted = false,

              },
              new Driver
              {
                  Id = 3,
                  firstName = "Ramadan3",
                  creationDate = DateTime.Now.Date,
                  lastName = "Essam",
                  Email = "Ramadan3@gmail.com",
                  phoneNumber = "+01028987873",
                  isDeleted = false,


              }
              );
        }
    }
}