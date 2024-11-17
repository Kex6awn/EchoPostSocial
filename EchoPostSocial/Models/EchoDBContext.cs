using Microsoft.EntityFrameworkCore;

namespace EchoPostSocial.Models
{
    public class EchoDBContext : DbContext
    {
        // DbSet<Login> User represents the collection of all Login objects
        public DbSet<Login> User { get; set; } = null!;

        // Constructor to pass DbContextOptions to the base class
        public EchoDBContext(DbContextOptions<EchoDBContext> options) : base(options) { }

        // OnModelCreating is used to define the initial data for the Login entity
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Explicitly define userId as the primary key
            modelBuilder.Entity<Login>().HasKey(l => l.userId);

            // Seed some initial Login data, including firstName and lastName
            modelBuilder.Entity<Login>().HasData(
                new Login()
                {
                    userId = 1,
                    userName = "example",
                    password = "password",
                    firstName = "John",
                    lastName = "Doe"
                },
                new Login()
                {
                    userId = 2,
                    userName = "example1",
                    password = "password1",
                    firstName = "Jane",
                    lastName = "Smith"
                }
            );
        }
    }
}